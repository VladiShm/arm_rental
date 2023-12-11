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
    public partial class PersonArea : Form
    {

        SqlCommands commands = new SqlCommands();
        string tableName = Autorization_Form.whoIs;
        public PersonArea()
        {
            InitializeComponent();
        }

        public void LoadInfo()
        {
            try
            {
                string sql = $"SELECT name, surname, phone from {tableName} as t join accounts a on " +
                    $"a.id = t.id_account where login = @login and password = @password";
                DataTable dt = new DataTable();
                commands.Connection();
                using (var cmd = new NpgsqlCommand(sql, commands.strCon))
                {
                    cmd.Parameters.AddWithValue("login", Autorization_Form.log);
                    cmd.Parameters.AddWithValue("password", Autorization_Form.pass);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["name"].ToString();
                    textBox2.Text = dr["surname"].ToString();
                    textBox3.Text = dr["phone"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonArea_Load(object sender, EventArgs e)
        {
            CenterToParent();
            LoadInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old_name = textBox1.Text;
            string old_surname = textBox2.Text;
            string old_phone = textBox3.Text;
            string sql = $"UPDATE {tableName} SET name = @name, surname = @surname, phone = @phone WHERE id_account = @id";
            commands.Connection();
            using (var cmd = new NpgsqlCommand(sql, commands.strCon))
            {
                cmd.Parameters.AddWithValue("name", textBox1.Text);
                cmd.Parameters.AddWithValue("surname", textBox2.Text);
                cmd.Parameters.AddWithValue("phone", textBox3.Text);
                cmd.Parameters.AddWithValue("id", Autorization.acc_id);

                cmd.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
