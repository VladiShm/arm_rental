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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace arm_rental
{
    public partial class AddClients : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public AddClients()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int mx_id = 1;
                string command;
                //добавляем клиента
                if (AddAccounts.whoIs == 1)
                {
                    command = "insert into clients (name, surname, phone, id_account) values (@name, @surname, @phone,@id_account)";
                }
                //добавляем дамина
                else
                {
                    command = "insert into admins (name, surname, phone, id_account) values (@name, @surname, @phone,@id_account)";
                }
                sqlCommands.Connection();
                string command2 = "select max(id) from accounts";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    object res = cmd.ExecuteScalar();
                    mx_id = (res != DBNull.Value) ? Convert.ToInt32(res) : mx_id;
                }

                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@name", tbName.Text);
                    cmd.Parameters.AddWithValue("@surname", tbSurname.Text);
                    cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                    cmd.Parameters.AddWithValue("@id_account", mx_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
           
    }
}
