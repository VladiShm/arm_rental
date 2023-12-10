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
    public partial class AddVisits : Form
    {
        List<int> client_id, inventories_id;
        SqlCommands sqlCommands = new SqlCommands();
        public AddVisits()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void AddVisits_Load(object sender, EventArgs e)
        {
            client_id = new List<int>();
            inventories_id = new List<int>();

            string comm1 = "select id, name, surname from clients";
            sqlCommands.Connection();
            DataTable dt = new DataTable();
            using (var cmd = new NpgsqlCommand(comm1, sqlCommands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                foreach (DataRow item in dt.Rows)
                {
                    comboBox1.Items.Add($"{item["name"].ToString()} {item["surname"].ToString()}");
                    client_id.Add(Convert.ToInt32(item["id"]));
                }
            }
            comboBox1.Items.Add("Свободная аренда");

            string comm2 = "select id_i, inventory, price from inventories";
            sqlCommands.Connection();
            DataTable dt2 = new DataTable();
            using (var cmd = new NpgsqlCommand(comm2, sqlCommands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt2.Load(dr);

                foreach (DataRow item in dt2.Rows)
                {
                    comboBox2.Items.Add($"{item["inventory"].ToString()} {item["price"].ToString()}");
                    inventories_id.Add(Convert.ToInt32(item["id_i"]));
                }
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string comm;
            if (comboBox1.SelectedItem == "Свободная аренда")
            {
                comm = "insert into rentals (inventories_id) values (@inventories_id)";
            }
            else
            {
                comm = "insert into rentals (client_id, inventories_id) values (@c_id, @inventories_id)";
            }
            using (var cmd = new NpgsqlCommand(comm, sqlCommands.strCon))
            {
                if (comboBox1.SelectedItem != "Свободная аренда")
                {
                    cmd.Parameters.AddWithValue("c_id", client_id[comboBox1.SelectedIndex]);
                }

                cmd.Parameters.AddWithValue("inventories_id", inventories_id[comboBox2.SelectedIndex]);

                cmd.ExecuteNonQuery();
                this.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
