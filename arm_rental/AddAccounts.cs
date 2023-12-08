using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arm_rental
{
    public partial class AddAccounts : Form
    {
        public static int whoIs;
        SqlCommands sqlCommands = new SqlCommands();
        public AddAccounts()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "insert into accounts (login, password, id_role) values (@login, @password, @id_role)";
                sqlCommands.Connection();
                var p = Autorization.NewHash(Autorization.GenerateHash(textBoxPass.Text));
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@password", Autorization.NewHash(Autorization.GenerateHash(textBoxPass.Text)));
                    cmd.Parameters.AddWithValue("@id_role", (comboBoxRole.SelectedIndex + 1));

                    cmd.ExecuteNonQuery();
                }

                whoIs = comboBoxRole.SelectedIndex + 1;
                if (whoIs == 1)
                {
                    AddClients addClient = new AddClients();
                    addClient.Show();
                }
                else
                {
                    AddClients addClient = new AddClients();
                    addClient.Show();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении пользователя");
                this.Close();
            }
        }
    }
}
