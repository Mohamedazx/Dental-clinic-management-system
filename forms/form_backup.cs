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

namespace dintist.forms
{
    public partial class form_backup : Form
    {
        // 
        //server=192.168.1.20,1433;Initial Catalog=Dentist;  User ID=hosny;Password=Hosnyaz123
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP - RH94TE5; Initial Catalog = Dentist; Persist Security Info=True;User ID = hosny; Password=Hosnyaz123");
        
        public form_backup()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                packup_path.Text = dlg.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
          /*  try
            {*/

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "backup DATABASE Dentist to disk ='" + packup_path.Text + "\\" + "Dentist" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bak'";
                cmd.ExecuteNonQuery();
                conn.Close();
               // conn.Dispose();
               

                MessageBox.Show("تم عمل نسخه احتياطية");
          /*  }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files (*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restore_path.Text = dlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // conn.Close();
            try
            {
                conn.Open();
                string sql1 = "Alter Database Dentist Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                string sql2 = "USE MASTER RESTORE DATABASE [Dentist] FROM  DISK = '" + restore_path.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                string sql3 = "Alter Database Dentist Set MULTI_USER";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
               // conn.Dispose();
                MessageBox.Show("تم اعادة البينات بنجاح");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void form_backup_Load(object sender, EventArgs e)
        {

        }
    }
}
