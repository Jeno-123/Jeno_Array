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
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lblNumMale.Text = showCount(2, "Male").ToString();
            lblNumFemale.Text = showCount(2, "Female").ToString();
            lblNumBasket.Text = showCount(3, "Basketball").ToString();
            lblNumVolley.Text = showCount(3, "Volleyball").ToString();
            lblNumSoccer.Text = showCount(3, "Soccer").ToString();
            lblNumBsit.Text = showCount(11, "BSIT").ToString();
            lblNumBeed.Text = showCount(11, "BEED").ToString();
            lblNumPink.Text = showCount(6, "Pink").ToString();
            lblNumBlue.Text = showCount(6, "Blue").ToString();
            lblNumRed.Text = showCount(6, "Red").ToString();
            lblNumGreen.Text = showCount(6, "Blue").ToString();
            lblNumActive.Text = showCount(12, "1").ToString();
            lblNumInactive.Text = showCount(12, "0").ToString();
        }

        public int showCount(int c, string val)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx");
            Worksheet sh = book.Worksheets[0];
            int row = sh.Rows.Length;
            int Counter = 0;
            for (int i = 2; i <= row; i++)
            {
                if (sh.Range[i, c].Value == val)
                {
                    Counter++;

                }
            }
            return Counter;
        }

        private void btnActiveStudents_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("1");
            fm2.Show();
        }

        private void btnInactiveStudent_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("0");
            fm2.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
