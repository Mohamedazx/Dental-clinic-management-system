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
    public partial class income : Form
    {
        dintist.PL.pati ob = new dintist.PL.pati();
        DataTable dt = new DataTable();
        public void income_constractor()
        {

            dt = ob.view_income();
            dgv.DataSource = dt;

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 300;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 220;
            dgv.Columns[4].Width = 220;
            dgv.Columns[5].Width = 300;




            dgv.Columns[3].DefaultCellStyle.Format = "c";
            dgv.Columns[4].DefaultCellStyle.Format = "c";
            dgv.Columns[5].DefaultCellStyle.Format = "c";

           // Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-US");
            dgv.AllowUserToAddRows = false;






        }
        public income()
        {
            InitializeComponent();
            income_constractor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           /* if (search.Text == "")
            {
                income_constractor();
            }
            else
            {
                try
                {

                    dt = ob.search_income(Convert.ToString(search.Text));
                    this.dgv.DataSource = dt;

                    Double sum = 0, x = 0, y = 0;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        x += Convert.ToDouble(dgv.Rows[i].Cells[3].Value);
                        y += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
                        sum += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
                    }
                    costs.Text = x.ToString();
                    payids.Text = y.ToString();
                    rems.Text = sum.ToString();


                }
                catch
                {
                    return;
                }
            }*/
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void income_Load(object sender, EventArgs e)
        {
            Double sum = 0,x=0,y=0;
           for(int i=0;i < dgv.Rows.Count; i++)
            {
                x +=Convert.ToDouble( dgv.Rows[i].Cells[3].Value);
                y += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
               sum += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
            }
            total_cost.Text = x.ToString();
            total_paid.Text = y.ToString();
            total_remind.Text = sum.ToString();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void costs_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            income_constractor();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            dt = ob.search_salary_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgv.DataSource = dt;
            Double sum = 0, x = 0, y = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[3].Value);
                y += Convert.ToDouble(dgv.Rows[i].Cells[4].Value);
                sum += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
            }
            costs.Text = x.ToString();
            payids.Text = y.ToString();
            rems.Text = sum.ToString();
        }
    }
}
