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
    public partial class InventoryChange : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        List<int> idInvent = new List<int>();
        public InventoryChange()
        {
            InitializeComponent();
        }

        private void InventoryChange_Load(object sender, EventArgs e)
        {
            CenterToParent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            try
            {
                sqlCommands.Connection();
                string command2 = "select id_i, inventory from inventories";
                DataTable dt = new DataTable();
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow i in dt.Rows)
                    {
                        idInvent.Add(Convert.ToInt32(i["id_i"]));
                        comboBox1.Items.Add(i["inventory"]);
                    }
                }


            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command2 = "update inventories set inventory = @invent, price = @price where id_i = @id";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("invent", textBox1.Text);
                    cmd.Parameters.AddWithValue("price", Convert.ToInt32(textBox2.Text));
                    cmd.Parameters.AddWithValue("id", idInvent[comboBox1.SelectedIndex]);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
