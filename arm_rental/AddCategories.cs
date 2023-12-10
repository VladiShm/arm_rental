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
    public partial class AddCategories : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public AddCategories()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                string command = "insert into categories (category, id_season) values (@category, @id_season)";
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@category", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@id_season", comboBox1.SelectedIndex + 1);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
