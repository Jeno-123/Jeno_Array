using Spire.Xls;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            bool log = false;
            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 8].Value == txtUsername.Text && sheet.Range[i, 9].Value == txtPassword.Text)
                {
                    log = true;
                    break;
                }
                else
                {
                    log = false;
                }
            }
            if (log == true)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
    

