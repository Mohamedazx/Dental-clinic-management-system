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


namespace dintist.forms
{
    public partial class New_Bill : Form
    {
        public void Bill_Manegment_constractor()
        {

            dt = ob.view_all_bills();
            dgv.DataSource = dt;

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 250;
            dgv.Columns[2].Width = 400;
            dgv.Columns[3].Width = 250;
            dgv.Columns[4].Width = 350;

            dgv.Columns[1].DefaultCellStyle.Format = "c";
            dgv.AllowUserToAddRows = false;

           // Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-US");

        }
        PL.spendings ob = new PL.spendings();
        DataTable dt = new DataTable();
 
        
        public New_Bill()
        {
            InitializeComponent();
            Bill_Manegment_constractor();

            dt = ob.show_BILL_id();
            bill_id.Text = dt.Rows[0][0].ToString();
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "Images File :|*.ipg;*.gif;*.Bmb;*.png";
            if (x.ShowDialog() == DialogResult.OK)
            {
                ptis.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            spending f = new spending();
            f.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
          
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showImgToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            patient_img f = new patient_img();
            byte[] bill_img = (byte[])ob.show_biil_img(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value)).Rows[0][0];
            MemoryStream ms = new MemoryStream(bill_img);
            f.pictureBox1.Image = Image.FromStream(ms);
            f.ShowDialog();**/

        }

        private void showImgToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            patient_img f = new patient_img();
            byte[] bill_img = (byte[])ob.show_biil_img(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value)).Rows[0][0];
            MemoryStream ms = new MemoryStream(bill_img);
            f.pictureBox1.Image = Image.FromStream(ms);
            f.ShowDialog();
        }

        private void New_Bill_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
         /*   if (search.Text == "")
            {
                Bill_Manegment_constractor();
            }
            else
            {
                try
                {

                    dt = ob.search_bill_info(Convert.ToString(search.Text));
                    this.dgv.DataSource = dt;

                  
                   


                }
                catch
                {
                    return;
                }
            }*/
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton27_Click_1(object sender, EventArgs e)
        {
            dt = ob.search_bill_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgv.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[1].Value);

            }
            totalamo.Text = x.ToString();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Bill_Manegment_constractor();
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                ob.delete_bill_info(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value));
                Bill_Manegment_constractor();
            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            spending f = new spending();
            f.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click_3(object sender, EventArgs e)
        {
            byte[] img;
            MemoryStream ms1 = new MemoryStream();
            ptis.Image.Save(ms1, ptis.Image.RawFormat);
            img = ms1.ToArray();

            try
            {


                ob.new_bill(int.Parse(bill_id.Text), Convert.ToString(amount.Text), comment.Text, Convert.ToDateTime(dateTimePicker1.Value.ToString()), img);
                MessageBox.Show("a new bill has been add successfully...", "Adding New Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bill_Manegment_constractor();
                dt = ob.show_BILL_id();
                bill_id.Text = dt.Rows[0][0].ToString();
                amount.Text = " ";
                comment.Text = "";




            }

            catch
            {
                MessageBox.Show("pleas enter fall info ...", "Adding New Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void bunifuThinButton22_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "Images File :|*.jpg;*.gif;*.Bmb;*.png";
            if (x.ShowDialog() == DialogResult.OK)
            {
                ptis.Image = Image.FromFile(x.FileName);
            }
        }
    }
}
