using dintist.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.IO;


//using dintist.Reporting;
//using DevExpress.XtraReports.UI;

namespace dintist.forms
{

    public partial class patients_Manegment : Form

    {
        
        string delet_users;

        private static patients_Manegment n;
        static void cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }
        public static patients_Manegment deleg
        {
            get
            {
                if (n == null)
                {
                    n = new patients_Manegment();
                }
                return n;
            }
        }

        dintist.PL.pati ob = new dintist.PL.pati();
        DataTable dt = new DataTable();
        public void Patients_Manegment_constractor()
        {

            dt = ob.view_all_patients();
            dgp.DataSource = dt;

            dgp.Columns[0].Width = 55;
            dgp.Columns[1].Width = 120;
            dgp.Columns[2].Width = 165;
            dgp.Columns[3].Width = 65;
            dgp.Columns[4].Width = 85;
            dgp.Columns[5].Width = 120;
            dgp.Columns[6].Width = 115;
            dgp.Columns[7].Width = 100;
            dgp.Columns[8].Width = 190;
            dgp.Columns[9].Width = 95;
            dgp.Columns[10].Width = 95;
            dgp.Columns[11].Width = 95;
            dgp.Columns[12].Width = 155;

            dgp.Columns[8].DefaultCellStyle.Format = "d";



            dgp.Columns[9].DefaultCellStyle.Format = "c";
            dgp.Columns[10].DefaultCellStyle.Format = "c";
            dgp.Columns[11].DefaultCellStyle.Format = "c";

           // Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-US");
            dgp.AllowUserToAddRows = false;
         






        }
        public patients_Manegment()
        {
            InitializeComponent();

            Patients_Manegment_constractor();
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

        private void showPatientImgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.patient_img f = new patient_img();
            byte[] pa_img = (byte[])ob.show_patient_img(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value)).Rows[0][0];
            MemoryStream ms = new MemoryStream(pa_img);
            f.pictureBox1.Image = Image.FromStream(ms);
            f.ShowDialog();

        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
            if (search.text == "")
            {
                Patients_Manegment_constractor();
            }
            else
            {
                try
                {

                    dt = ob.search_patient_info(Convert.ToString(search.text));
                    this.dgp.DataSource = dt;
                    
                   
                }
                catch
                {
                    return;
                }
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
          
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patients_Manegment_constractor();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            
           



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DG == DialogResult.Yes)
                {
                    ob.delete_patient_info(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    Patients_Manegment_constractor();
                }
                else if (DG == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                return;
            }

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
           
        }

        private void btn_Landscape_Click(object sender, EventArgs e)
        {
          /*  panel2.Visible = false;
            Reporting.landscape ob = new Reporting.landscape();
            ob.ShowPreview();*/
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {












        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patients_Manegment_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patients_Manegment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentistDataSet.Table_patients' table. You can move, or remove it, as needed.
           // this.table_patientsTableAdapter.Fill(this.dentistDataSet.Table_patients);//

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void panel_contact_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablepatientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void d1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void d2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dt = ob.search_patient_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgp.DataSource = dt;
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            patients f = new patients();
            f.Show();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            try
            {
                patients f = new patients();
                f.add.Visible = false;

                f.delet.Visible = false;

                f.update.Visible = true;
                f.update.Location = new Point(8, 70);
                f.update.Size = new Size(f.add.Size.Width, f.add.Size.Height * 4);
                f.label4.Text = "Updating info";
                f.text_id.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();
                f.text_tc.Text = this.dgp.CurrentRow.Cells[1].Value.ToString();
                f.text_name.Text = this.dgp.CurrentRow.Cells[2].Value.ToString();
                f.txt_patient_age.Text = this.dgp.CurrentRow.Cells[3].Value.ToString();
                if (this.dgp.CurrentRow.Cells[4].Value.ToString() == "male")
                {
                    f.radioButton1.Checked = true;
                }
                else
                {
                    f.radioButton2.Checked = true;
                }

                f.txt_phone.Text = this.dgp.CurrentRow.Cells[5].Value.ToString();
                f.comboBox_state.SelectedItem = Convert.ToString(this.dgp.CurrentRow.Cells[6].Value);
                f.date.Value = Convert.ToDateTime(this.dgp.CurrentRow.Cells[7].Value.ToString());
                f.text_email.Text = this.dgp.CurrentRow.Cells[8].Value.ToString();
                f.cost.Text = this.dgp.CurrentRow.Cells[9].Value.ToString();
                f.text_pay.Text = this.dgp.CurrentRow.Cells[10].Value.ToString();
                f.text_rem.Text = this.dgp.CurrentRow.Cells[11].Value.ToString();
                f.com.Text = this.dgp.CurrentRow.Cells[12].Value.ToString();
                byte[] pt_img = (byte[])ob.show_patient_img(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value)).Rows[0][0];
                MemoryStream ms = new MemoryStream(pt_img);
                f.pti_img.Image = Image.FromStream(ms);
                f.Show();
                Patients_Manegment_constractor();
            }
            catch
            {
                return;

            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            Patients_Manegment_constractor();
        }

        private void bunifuThinButton27_Click_1(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالحذف  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DG == DialogResult.Yes)
                    {
                        ob.delete_patient_info(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                        Patients_Manegment_constractor();
                    }
                    else if (DG == DialogResult.No)
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
          /*  XtraReport1 g = new XtraReport1();
            g.ShowPreviewDialog();*/
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
           /* XtraReport2 f = new XtraReport2();

            /*  f.id.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();

              f.name.Text = this.dgp.CurrentRow.Cells[2].Value.ToString();
              f.age.Text = this.dgp.CurrentRow.Cells[3].Value.ToString();


              f.state.Text = Convert.ToString(this.dgp.CurrentRow.Cells[6].Value);
              f.date.Text = this.dgp.CurrentRow.Cells[7].Value.ToString();

              f.cost.Text = this.dgp.CurrentRow.Cells[9].Value.ToString();
              f.payed.Text = this.dgp.CurrentRow.Cells[10].Value.ToString();
              f.rem.Text = this.dgp.CurrentRow.Cells[11].Value.ToString();
              f.com.Text = this.dgp.CurrentRow.Cells[12].Value.ToString();*/

           // f.ShowPreview();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            home g = new home();
            g.Show();
            this.Hide();
        }
    }
}
