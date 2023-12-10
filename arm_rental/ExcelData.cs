using Npgsql;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace arm_rental
{
    internal class ExcelData
    {
        public static SqlCommands commands = new SqlCommands();

        public static void GetInfo()
        {
            DataTable dataTable = new DataTable();
            try
            {
                commands.Connection();
                string command = "select name, surname, phone inventory, price from rentals as r join clients as c on r.client_id = c.id join inventories as i on r.inventories_id = i.id_i";
                dataTable = new DataTable();
                using (var cmd = new NpgsqlCommand(command, commands.strCon))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dataTable.Load(dr);
                }
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    string[] columnNames = { "Имя клиента", "Фамилия клиента", "Телефон клиента", "Название инвентаря", "Цена"};
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = columnNames[i];
                    }

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int column = 0; column < dataTable.Columns.Count; column++)
                        {
                            worksheet.Cells[row + 2, column + 1].Value = dataTable.Rows[row][column];
                        }
                    }

                    string currentTime = DateTime.Now.ToString("HHmmss");
                    FileInfo excelFile = new FileInfo($"C:\\Users\\vladi\\source\\repos\\arm_rental\\отчет\\file_{currentTime}.xlsx");
                    package.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
