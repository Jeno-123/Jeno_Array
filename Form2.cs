using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Jeno_Array
{
    public partial class Form2 : Form
    {

        Workbook book = new Workbook();
        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }

        private void LoadExcelFile()
        {
           
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;
        }


    
        public void insert(String name, String gender, String hobbies, String color, String saying)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = name;
            dataGridView1.Rows[i].Cells[1].Value = gender;
            dataGridView1.Rows[i].Cells[2].Value = hobbies;
            dataGridView1.Rows[i].Cells[3].Value = color;
            dataGridView1.Rows[i].Cells[4].Value = saying;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        public void update(int id, string name, string gender, string hobbies, string favoritecolor, string saying)
        {

            dataGridView1.Rows[id].Cells[0].Value = name;
            dataGridView1.Rows[id].Cells[1].Value = gender;
            dataGridView1.Rows[id].Cells[2].Value = hobbies;
            dataGridView1.Rows[id].Cells[3].Value = favoritecolor;
            dataGridView1.Rows[id].Cells[4].Value = saying;

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int r = dataGridView1.CurrentCell.RowIndex;
            form1.txtName.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            form1.lblid.Text = r.ToString();
            string gender = dataGridView1.Rows[r].Cells[1].Value.ToString();
            string[] gen = gender.Split();
            if (gender.Trim() == "Male")
            {
                form1.rbMale.Checked = true;
            }
            if (gender.Trim() == "Female")
            {
                form1.rbFemale.Checked = true;
            }
            string hobbies = dataGridView1.Rows[r].Cells[2].Value.ToString();
            string[] hob = hobbies.Split(',');
            foreach (string h in hob)
            {
                if (h.Trim() == "Basketball")
                {
                    form1.cbBasketball.Checked = true;
                }
                if (h.Trim() == "Volleyball")
                {
                    form1.cbVolleyball.Checked = true;
                }
                if (h.Trim() == "Soccer")

                {
                    form1.cbSoccer.Checked = true;
                }
            }
            form1.cmbColor.SelectedItem = dataGridView1.Rows[r].Cells[3].Value.ToString();
            form1.txtSaying.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();


            //dataGridView1.Rows[i].Cells[0].Value.ToString();
            //dataGridView1.Rows[i].Cells[1].Value.ToString();
            //dataGridView1.Rows[i].Cells[2].Value.ToString();
            //dataGridView1.Rows[i].Cells[3].Value.ToString();
            //dataGridView1.Rows[i].Cells[4].Value.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells[0].Value.ToString().Equals(txtSearch.Text))
                {
                    i.Selected = true;
                    break;
                }
            }
        }

        public void showStudent(string status)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\JannaSaveExcel2.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();

            DataRow[] row = dt.Select("STATUS=" + status);

            int count = 0;

            foreach (DataRow r in row)
            {

                dataGridView1.Rows.Insert(count,
                     r[0],
                     r[1],
                     r[2],
                     r[3],
                     r[4],
                     r[5],
                     r[6],
                     r[7],
                     r[8],
                     r[9],
                     r[10],
                     r[11],
                     r[12]
                     );
                count++;
            }


        }



    }
}
