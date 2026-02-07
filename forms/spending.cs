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
using System.Threading;
using System.Globalization;
using System.IO;

using dintist.PL;


namespace dintist.forms
{
    public partial class spending : Form
    {
        DataTable dt = new DataTable();
        string type;
        logins ob = new logins();
        string delet_users;


        public spending()
        {
            InitializeComponent();
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            New_Bill f = new New_Bill();
            f.ShowDialog();
            this.Close();
        }
       
       
        private void spending_Load(object sender, EventArgs e)
        {
            dt = ob.cutsh_type();
            typee.Text = dt.Rows[0][0].ToString();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          

        }

      

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            New_salary f =new New_salary();
            f.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_Bill f = new New_Bill();
            f.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            New_Bill f = new New_Bill();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                New_salary f = new New_salary();
                f.Show();
                this.Hide();
            }
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }
    }
}
