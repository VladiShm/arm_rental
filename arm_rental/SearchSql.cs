using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arm_rental
{
    public partial class SearchSql : Form
    {
        SqlCommands commands = new SqlCommands();
        public SearchSql()
        {
            InitializeComponent();
            try
            {
                DataTable dt = commands.GetData(@"select translate from metadata");
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxFields.Items.Add(dr["translate"].ToString());
                }
                CenterToParent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SearchSql_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOneFieldRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBoxFieldsRes.Items.Contains(listBoxFields.SelectedItems[0]))
                    listBoxFieldsRes.Items.Add(listBoxFields.SelectedItems[0]);
            }
            catch { MessageBox.Show("Выберите поля"); }
        }


        private void buttonManyFieldsRight_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var i in listBoxFields.Items)
                {
                    if (!listBoxFieldsRes.Items.Contains(i))
                        listBoxFieldsRes.Items.Add(i);
                }
            }
            catch { MessageBox.Show("Выберите поля"); }
        }

        private void buttonOneFieldLeft_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxFieldsRes.Items.Remove(listBoxFieldsRes.SelectedItems[0]);
            }
            catch { MessageBox.Show("Выберите поля"); }
        }

        private void buttonManyFieldsLeft_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxFieldsRes.Items.Clear();
            }
            catch { MessageBox.Show("Выберите поля"); }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var i in listBoxFields.Items)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            comboBox2.Items.Add("=");
            comboBox2.Items.Add("<>");
            if (comboBox1.SelectedItem.ToString() == "Цена")
            {
                comboBox2.Items.Add("<");
                comboBox2.Items.Add("<=");
                comboBox2.Items.Add(">");
                comboBox2.Items.Add(">=");
            }
            string com1 = "select column_name, table_name from metadata where translate = @translate";
            string column_name = "";
            string table_name = "";
            DataTable dt = new DataTable();
            commands.Connection();
            using (var cmd = new NpgsqlCommand(com1, commands.strCon))
            {
                cmd.Parameters.AddWithValue("translate", comboBox1.SelectedItem);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    column_name = item["column_name"].ToString();
                    table_name = item["table_name"].ToString();
                }
            }

            string com2 = $"select {column_name} from {table_name}";
            using (var cmd = new NpgsqlCommand(com2, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    if (!comboBox3.Items.Contains(item[$"{column_name}"].ToString()) && !string.IsNullOrEmpty(item[$"{column_name}"].ToString()))
                        comboBox3.Items.Add(item[$"{column_name}"].ToString());
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            string param = "";
            foreach (var it in listBoxFieldsRes.Items)
            {
                string com3 = "select column_name, table_name from metadata where translate = @translate";
                using (var cmd = new NpgsqlCommand(com3, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("translate", it);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        param += $"{dr["table_name"].ToString()[0]}.{dr["column_name"].ToString()},";

                    }
                    dr.Close();
                }
            }
            param = param.Substring(0, param.Length - 1);
            string com1;
            DataTable data = new DataTable();
            if (listView1.Items.Count > 0)
            {
                com1 = $"select {param} from rentals as r join clients as c on c.id = r.client_id join inventories as i on r.inventories_id = i.id_i join categories as cat on i.id_category = cat.id_c join seasons as s on cat.id_season = s.id_s where ";
            }
            else
            {
                com1 = $"select {param} from rentals as r join clients as c on c.id = r.client_id join inventories as i on r.inventories_id = i.id_i join categories as cat on i.id_category = cat.id_c join seasons as s on cat.id_season = s.id_s ";
            }

            int count = 0;
            foreach (ListViewItem i in listView1.Items)
            {
                DataTable dt2 = new DataTable();
                NpgsqlDataReader dr;
                string com = "select column_name, table_name from metadata where translate = @translate";
                using (var cmd = new NpgsqlCommand(com, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("translate", i.SubItems[0].Text);
                    dr = cmd.ExecuteReader();
                    dt2.Load(dr);
                    foreach (DataRow el in dt2.Rows)
                    {
                        if (count == listView1.Items.Count - 1)
                            com1 += $" {el["table_name"].ToString()[0]}.{el["column_name"].ToString()} {i.SubItems[1].Text} '{i.SubItems[2].Text}'";
                        else
                        {
                            com1 += $" {el["table_name"].ToString()[0]}.{el["column_name"].ToString()} {i.SubItems[1].Text} '{i.SubItems[2].Text}' {i.SubItems[3].Text} ";
                        }
                    }

                }
                count++;
            }

            DataTable dt = new DataTable();
            using (var cmd = new NpgsqlCommand(com1, commands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
               // textBox1.Text = com1;
            }
            dataGridView1.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string> { comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString() };
            listView1.Items.Add(new ListViewItem(fields.ToArray()));
        }
    }

}
