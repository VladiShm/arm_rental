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
    public partial class DeleteClients : Form
    {
        List<int> idClient = new List<int>();
        SqlCommands sqlCommands = new SqlCommands();
        public DeleteClients()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void DeleteClients_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            try
            {
                sqlCommands.Connection();
                string command2 = "select id, name, surname from clients";
                DataTable dt = new DataTable();
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    foreach (DataRow i in dt.Rows)
                    {
                        idClient.Add(Convert.ToInt32(i["id"]));
                        comboBoxClient.Items.Add($"{i["name"]} {i["surname"]}");
                    }
                }


            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
