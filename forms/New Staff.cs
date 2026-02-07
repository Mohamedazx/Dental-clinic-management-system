using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using dintist.forms;
using dintist.PL;

namespace dintist.forms
{
    public partial class new_staff : Form
    {


        Staff ob = new Staff();
        DataTable dt = new DataTable();
      
        string gender;
        public new_staff()
        {
            InitializeComponent();

           // this.BackColor = Color.FromArgb(253, 253, 253);
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToShortTimeString();


            

            dt = ob.show_staff_id();
            text_id.Text = dt.Rows[0][0].ToString();
            /* number_of_Staff = dt.Rows.Count;
             if (number_of_Staff > 0)
             {
                 text_id.Text = Convert.ToString(number_of_Staff+1);
             }
             else
             {
                 text_id.Text = "1";
             }*/


        }

       

       

       

       

        private void bunifuThinButton21_Click(object sender, EventArgs e)


        {


           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
               
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void new_staff_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "famale";
            }



            try
            {

                ob.New_Staff(int.Parse(text_id.Text), text_tc.Text, text_name.Text, Convert.ToInt32(txt_Staff_age.Text), gender,
                    txt_phone.Text, Convert.ToDateTime(date.Value.ToShortDateString()), text_email.Text, com.Text);

                MessageBox.Show("a new staff has been add successfully...", "adding new Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                return;
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "famale";
            }

            try
            {
                ob.New_Staff(Convert.ToInt32(text_id.Text), text_tc.Text, text_name.Text, Convert.ToInt32(txt_Staff_age.Text), gender
                    ,
                     txt_phone.Text, Convert.ToDateTime(date.Value.ToShortDateString()), text_email.Text, com.Text);



                MessageBox.Show("a new Staff has been add Updated ...", "adding new Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch
            {
                return;
            }

            dt = ob.view_all_staffs();
            Staff_mangment.deleg.dgv.DataSource = dt;
        }

        private void delet_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
