using Npgsql;
using System;
using System.Collections;
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
    public partial class AddInventories : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        Dictionary<int, string> category = new Dictionary<int, string>();
        public AddInventories()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command = "insert into inventories (inventory, id_category, price) values (@inv, @id_c, @price)";
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("inv", textBoxName.Text);
                    cmd.Parameters.AddWithValue("id_c", category.FirstOrDefault(x => x.Value == comboBoxCategory.SelectedItem).Key);
                    //добавить проверку на int
                    cmd.Parameters.AddWithValue("price", int.Parse(textBoxPrice.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void AddInventories_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command = "select id_c, category from categories";
                DataTable dt = new DataTable();
                NpgsqlDataReader dr;
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow i in dt.Rows)
                    {
                        category.Add(Convert.ToInt32(i["id_c"].ToString()), i["category"].ToString());
                        comboBoxCategory.Items.Add(i["category"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
