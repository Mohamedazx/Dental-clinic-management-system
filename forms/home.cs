using dintist.forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dintist.forms
{
    public partial class home : Form
    {
        DataTable dt = new DataTable();
      
        PL.logins ob = new PL.logins();
        string delet_users;
        public home()
        {
            InitializeComponent();
            
            label4.Text = DateTime.Now.ToShortDateString();
            label5.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("do you want to close the program. ?", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
         
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           /* dintist.forms.buckup_form f = new dintist.forms.backup();
            f.ShowDialog();
            this.Close();*/
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            patients b = new patients();
            b.ShowDialog();
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
          

        }

        private void button14_Click(object sender, EventArgs e)
        {
           
               
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = ob.cutsh_type();
            typee.Text = dt.Rows[0][0].ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            /*Disiner f = new Disiner();
            f.Show();*/
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            form_backup f = new form_backup();
            f.Show();
           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("do you want to close the program. ?", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            patients b = new patients();
            b.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            patients_Manegment b = new patients_Manegment();
            b.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                new_staff b = new new_staff();
                b.Show();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Staff_mangment f = new Staff_mangment();
                f.Show();
                this.Hide();
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                income f = new income();
                f.Show();
                this.Hide();
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            spending f = new spending();
           
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }
    }
}
