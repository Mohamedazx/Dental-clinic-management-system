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
using System.Data.SqlClient;
using Dentist1;



namespace dintist.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            password.isPassword = true;
            cb.Checked = false;
           
           
        }
        string type;
        dintist.PL.logins log = new dintist.PL.logins ();
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


        }

        private void chb_OnChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            /*Disiner f = new Disiner();
            f.ShowDialog();*/
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void Cerver_Click(object sender, EventArgs e)
        {
          /*  server f = new server();
            f.ShowDialog();*/
        }

        private void user_name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {


        }

        private void cb_OnChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton7_Click_2(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("هل تريد الخروج من البرنامج؟؟", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void cb_OnChange_1(object sender, EventArgs e)
        {
            if (cb.Checked == true)
            {
                password.isPassword = false;
            }
            else
            {
                password.isPassword = true;
            }
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            if (admin.Checked)
            {
                type = "admin";
            }
            else
            {
                type = "user";
            }
            try
            {
                DataTable dt = log.s_login(user_name.Text, password.Text, type);
                if (dt.Rows.Count > 0)
                {
                    log.set_user(user_name.Text, type);
                    home f = new home();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("برجاء ادخال البيانات صحيحه", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Error خطأ اتصال", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
