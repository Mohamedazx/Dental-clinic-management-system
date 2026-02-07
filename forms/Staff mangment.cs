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
    public partial class Staff_mangment : Form

    {
        Staff ob = new Staff();
        DataTable dt = new DataTable();

        private static Staff_mangment n;
        static void cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }
        public static Staff_mangment deleg
        {
            get
            {
                if (n == null)
                {
                    n = new Staff_mangment();
                }
                return n;
            }
        }

       
        public void Staff_manegment_constractor()
        {

            dt = ob.view_all_staffs();
            dgv.DataSource = dt;

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 170;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 150;
            dgv.Columns[6].Width = 150;
            dgv.Columns[7].Width = 200;
            dgv.Columns[8].Width = 200;




            dgv.AllowUserToAddRows = false;







        }
        public Staff_mangment()
        {
            InitializeComponent();

            Staff_manegment_constractor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
            {
                Staff_manegment_constractor();
            }
            else
            {


                dt = ob.search_staff_info(Convert.ToString(search.text));
                this.dgv.DataSource = dt;
               
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
           
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_manegment_constractor();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.Delete_staffs_info(Convert.ToString(this.dgv.CurrentRow.Cells[0].Value));
            Staff_manegment_constractor();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void btn_whatsapp_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_sms_Click(object sender, EventArgs e)
        {
           
          
        }

        private void send_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Protrait_Click(object sender, EventArgs e)
        {
         /*   panel2.Visible = false;
            Reporting.XtraReport1 ob = new Reporting.XtraReport1();
            ob.ShowPreview();*/
        }

        private void btn_Landscape_Click(object sender, EventArgs e)
        {
           /* panel2.Visible = false;
            Reporting.landscape ob = new Reporting.landscape();
            ob.ShowPreview();*/
        }

        private void showPatientImgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Staff_mangment_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                ob.Delete_staffs_info(Convert.ToString(this.dgv.CurrentRow.Cells[0].Value));
                Staff_manegment_constractor();
            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            new_staff f = new new_staff();
            f.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Staff_manegment_constractor();
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            dt = ob.search_staff_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgv.DataSource = dt;
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }
    }
}
