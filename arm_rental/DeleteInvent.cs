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
    public partial class DeleteInvent : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        public DeleteInvent()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void DeleteInvent_Load(object sender, EventArgs e)
        {
            string comm2 = "select inventory from inventories";
            sqlCommands.Connection();
            DataTable dt2 = new DataTable();
            using (var cmd = new NpgsqlCommand(comm2, sqlCommands.strCon))
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt2.Load(dr);

                foreach (DataRow item in dt2.Rows)
                {
                    comboBox1.Items.Add($"{item["inventory"].ToString()}");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string comm2 = "delete from inventories where inventory = @invent";
                sqlCommands.Connection();
                using (var cmd = new NpgsqlCommand(comm2, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("invent", comboBox1.SelectedItem);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Нет записей для удаления!");
            }
            this.Close();
        }
    }
}
