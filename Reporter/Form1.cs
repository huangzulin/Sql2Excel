using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Reporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var connectionStringPath = Path.Combine(dir, "con_str.txt");
            if (File.Exists(connectionStringPath))
            {
                var lines = File.ReadAllLines(connectionStringPath);
                if (lines.Any())
                {
                    this.txtConnectionString.Text = lines[0];
                }
            }
            this.txt_sql.Text = @"";
        }

        /// <summary>
        /// 生成报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtConnectionString.Text) || string.IsNullOrWhiteSpace(this.txt_sql.Text))
            {
                MessageBox.Show("connection string or sql is required");
            }


            var connectionString = this.txtConnectionString.Text.Trim();


            using (var connection = new SqlConnection(connectionString))
            {
                var dbArgs = new DynamicParameters();
                var sql = this.txt_sql.Text;
                var parms = this.txt_params.Text.Trim().Split('&');
                foreach (var pair in parms)
                {
                    if (string.IsNullOrWhiteSpace(pair)) continue;
                    dbArgs.Add(pair.Split('=')[0], pair.Split('=')[1]);
                }

                var items = connection.Query(sql, dbArgs).ToList();
                using (var package = new ExcelPackage())
                {
                    var sheet = package.Workbook.Worksheets.Add("报表");
                    var row = items.Count;
                    var col = items.Count > 0 ? ((IDictionary<string, object>)items[0]).Keys.Count : 0;

                    for (int i = 0; i < row; i++)
                    {
                        var item = items[i];

                        IDictionary<string, object> properties = (IDictionary<string, object>)item;
                        for (int j = 0; j < properties.Keys.Count; j++)
                        {
                            if (i == 0)
                            {
                                sheet.Cells[1, j + 1, 1, j + 1].Value = properties.Keys.ToList()[j];
                            }
                            sheet.Cells[i + 2, j + 1, i + 2, j + 1].Value = properties.Values.ToList()[j];
                        }

                    }
                    sheet.Cells[1, 1, row + 1, col].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, 1, row + 1, col].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, 1, row + 1, col].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, 1, row + 1, col].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();
                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            var filename = Path.Combine(fbd.SelectedPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xlsx");
                            using (FileStream fs = new FileStream(filename, FileMode.Create))
                            {
                                package.SaveAs(fs);
                            }
                            MessageBox.Show("已导出");
                            Process.Start("explorer.exe", fbd.SelectedPath);
                        }
                    }


                    
                }

            }


            


        }
    }
}
