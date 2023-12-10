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

namespace arm_rental
{
    public partial class DeleteForm : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public DeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                sqlCommands.Connection();
                string command2 = "delete from categories where category = @cat"; ;
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("cat", comboBox1.SelectedItem);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
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
                        comboBox1.Items.Add(i["category"].ToString());
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
