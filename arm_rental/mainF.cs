﻿using Npgsql;
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
    public partial class mainF : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        List<int> idFreeArenda = new List<int>();
        List<int> idRental = new List<int>();
        public static int id_inv;
        public mainF()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccounts addAccounts = new AddAccounts();
            addAccounts.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //добавить инвентарь
        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddInventories addInventories = new AddInventories();
            addInventories.Show();
        }

        //добавление категории инвенатря
        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddCategories addCategories = new AddCategories();
            addCategories.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteInvent deleteInvent = new DeleteInvent();
            deleteInvent.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCategories updateCategories = new UpdateCategories();
            updateCategories.Show();
        }


        private void listBoxInventories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FreeArenda()
        {
            try
            {
                listBox1.Items.Clear();
                listBoxFree.Items.Clear();
                sqlCommands.Connection();
                string command = "select r.inventories_id, inventory, category, price from rentals as r join inventories as i on r.inventories_id = i.id_i join categories as c on c.id_c = i.id_category where r.client_id is null";
                DataTable dt = new DataTable();
                NpgsqlDataReader dr;
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    string row;
                    foreach (DataRow i in dt.Rows)
                    {

                        idFreeArenda.Add(Convert.ToInt32(i["inventories_id"]));
                        row = $"Категория: {i["category"]} ║ Инвентарь: {i["inventory"]} ║ Цена: {i["price"]}";
                        listBoxFree.Items.Add(row);
                        listBox1.Items.Add(row);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Arenda()
        {
            try
            {
                listBoxInventories.Items.Clear();
                sqlCommands.Connection();
                string command = "select r.id,  name, inventory, price, category from rentals as r join clients as c on r.client_id = c.id join inventories as i on r.inventories_id = i.id_i join categories as cat on cat.id_c = i.id_category where r.client_id is not null";
                DataTable dt = new DataTable();
                NpgsqlDataReader dr;
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    string row;
                    foreach (DataRow i in dt.Rows)
                    {
                        row = $"Клиент: {i["name"]} ║ Категория: {i["category"]} ║  Инвентарь: {i["inventory"]} ║ Цена: {i["price"]}";
                        listBoxInventories.Items.Add(row);
                        idRental.Add(Convert.ToInt32(i["id"]));


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MyArenda()
        {
            try
            {
                myRental.Items.Clear();
                sqlCommands.Connection();
                int client_id;
                string command = "select id from clients where id_account = @id_acc";
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("id_acc", Autorization.acc_id);
                    client_id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                DataTable dt = new DataTable();
                NpgsqlDataReader dr;
                string command2 = "select inventory, category from rentals as r join inventories as i on id_i = r.inventories_id join categories as c on i.id_category = c.id_c where client_id = @id_client";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("id_client", client_id);
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    string row;
                    foreach (DataRow i in dt.Rows)
                    {
                        row = $"Категория: {i["category"]} ║ Инвентарь: {i["inventory"]}";
                        myRental.Items.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mainF_Load(object sender, EventArgs e)
        {
            Arenda();
            FreeArenda();
            MyArenda();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelData.GetInfo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddVisits addVisits = new AddVisits();
            addVisits.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arenda();
            FreeArenda();
            MyArenda();
        }

        private void buttonAddArenda_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommands.Connection();
                int id;
                string command2 = $"select id from clients where id_account  = {Autorization.acc_id}";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string command = "update rentals set client_id = @client where inventories_id = @id";
                using (var cmd = new NpgsqlCommand(command, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("client", id);
                    cmd.Parameters.AddWithValue("id", idFreeArenda[listBoxFree.SelectedIndex]);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Вы взяли в аренду!");
                }
                listBoxFree.Items.Clear();
                FreeArenda();
                MyArenda();

            }
            catch
            {
                MessageBox.Show("Нет свободной аренды!");
            }
        }

        private void listBoxFree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonArea personArea = new PersonArea();
            personArea.Show();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InventoryChange inventoryChange = new InventoryChange();
            inventoryChange.Show();
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteClients deleteClients = new DeleteClients();
            deleteClients.Show();
        }

        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Arenda();
            id_inv = idRental[Convert.ToInt32(listBoxInventories.SelectedIndex)];

            try
            {

                sqlCommands.Connection();
                string command2 = "delete from rentals where id = @id";
                using (var cmd = new NpgsqlCommand(command2, sqlCommands.strCon))
                {
                    cmd.Parameters.AddWithValue("id", id_inv);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBoxInventories_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void нестандарныеЗапросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSql searchSql = new SearchSql();
            searchSql.Show();
        }
    }
}
