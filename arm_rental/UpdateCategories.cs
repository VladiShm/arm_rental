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
    public partial class UpdateCategories : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public UpdateCategories()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void UpdateCategories_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command = "select category from categories";
                DataTable dt = new DataTable();
                NpgsqlDataReader dr;
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow i in dt.Rows)
                    {
                        comboBoxName.Items.Add(i["category"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxName.SelectedItem.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command = "update categories set category = @cat where category = @old_cat";
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("cat", textBox1.Text);
                    cmd.Parameters.AddWithValue("old_cat", comboBoxName.SelectedItem);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
