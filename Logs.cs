﻿using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeno_Array
{
    public partial class Logs: Form
    {
        MyLog L = new MyLog();
        public Logs()
        {
            InitializeComponent();
            L.showLogs(dataGridView1Logs);
        }

        class MyLog
        {
            Workbook book = new Workbook();
            public void insertLogs(string user, string message)
            {
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx");
                Worksheet sh = book.Worksheets[1];
                int row = sh.Rows.Length + 1;
                sh.Range[row, 1].Value = user;
                sh.Range[row, 2].Value = message;
                sh.Range[row, 3].Value = DateTime.Now.ToString("MM/dd/yyyy");
                sh.Range[row, 4].Value = DateTime.Now.ToString("HH:mm:ss: TT");
                book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx\");

                MyLog log = new MyLog();
                log.insertLogs("Name", "Message");


            }
            public void showLogs(DataGridView d)
            {
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx");
                Worksheet sh = book.Worksheets[0];
                DataTable dt = sh.ExportDataTable();
                d.DataSource = dt;

                //showLogs(dataGridView);
                // showLogs(dGVI);
            }
        }

        private void Logs_Load(object sender, EventArgs e)
        {

        }
    }
}
