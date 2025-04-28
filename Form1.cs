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
    public partial class Form1 : Form
    {
        Form2 Form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        string[] Student = new string[5];
        //int x = 0;
        int i = 0;
        

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string Dis = "";

            for (int x = 0; x < Student.Length; x++)
            {
                Dis += "[" + x + "]" + Student[x] + "\n";

            }
            //MessageBox.Show(Dis);
            Form2.Show();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";

            data += txtName.Text;
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            if (cbBasketball.Checked)
            {
                hobbies += cbBasketball.Text + ", ";
            }
            if (cbSoccer.Checked)
            {
                hobbies += cbSoccer.Text + ", ";
            }
            if (cbVolleyball.Checked)
            {
                hobbies += cbVolleyball.Text + ", ";
            }
            favoritecolor = cmbColor.Text; 
            saying = txtSaying.Text + ".";

            Student[i] = data;
            i++;
            Form2.insert(txtName.Text, gender, hobbies, favoritecolor, saying);
            txtName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbBasketball.Checked = false;
            cbVolleyball.Checked = false;
            cbSoccer.Checked = false;
            cmbColor.SelectedIndex = -1;
            txtSaying.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";

            data += txtName.Text;
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            if (cbBasketball.Checked)
            {
                hobbies += cbBasketball.Text + ", ";
            }
            if (cbSoccer.Checked)
            {
                hobbies += cbSoccer.Text + ", ";
            }
            if (cbVolleyball.Checked)
            {
                hobbies += cbVolleyball.Text + ", ";
            }
            favoritecolor = cmbColor.Text;
            saying = txtSaying.Text + ".";

            Student[i] = data;
            i++;
            Form2.update(Convert.ToInt32(lblid.Text),txtName.Text, gender, hobbies, favoritecolor, saying);

            txtName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbBasketball.Checked = false;
            cbVolleyball.Checked = false;
            cbSoccer.Checked = false;
            cmbColor.SelectedIndex = -1;
            txtSaying.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
