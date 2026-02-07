using Dentist1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dintist.PL
{
    class Staff
    {
       
       
        
        public void New_Staff(int sta_id,
            string staff_tc,
            string staff_nam,
            int staff_age,
            string gen,
            string pho,
            DateTime dat,
            string emi,
            string com)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@staff_id", SqlDbType.Int);
            p[0].Value = sta_id;
            p[1] = new SqlParameter("@staff_tc", SqlDbType.NVarChar, 50);
            p[1].Value = staff_tc;
            p[2] = new SqlParameter("@staff_name", SqlDbType.NVarChar, 50);
            p[2].Value = staff_nam;
            p[3] = new SqlParameter("@staff_age", SqlDbType.Int);
            p[3].Value = staff_age;
            p[4] = new SqlParameter("@staff_gender", SqlDbType.NVarChar, 50);
            p[4].Value = gen;
            p[5] = new SqlParameter("@staff_phone", SqlDbType.NVarChar, 50);
            p[5].Value = pho;
            
            p[6] = new SqlParameter("@staff_date", SqlDbType.Date);
            p[6].Value = dat;
            p[7] = new SqlParameter("@staff_email", SqlDbType.NVarChar, 50);
            p[7].Value = emi;
            p[8] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
            p[8].Value = com;

            ob.RUA("new_Staff", p);
            ob.close();
        }
        public DataTable show_staff_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_staff_id", null);
            ob.close();
            return dt;
        }
        public DataTable view_all_staffs()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_staffs", null);
            ob.close();
            return dt;
        }

      
        public DataTable search_staff_info(string staff_name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@staff_name", SqlDbType.NVarChar, 50);
            p[0].Value = staff_name;
            dt = ob.Reader("search_staff_info", p);
            ob.close();
            return dt;
        }

        public void Update_staff_info(int pat_id,
            string pat_tc,
            string pat_nam,
            int pat_age,
            string gen,
            string pho,
            
            DateTime dat,
            string emi)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@staff_id", SqlDbType.Int);
            p[0].Value = pat_id;
            p[1] = new SqlParameter("@staff_tc", SqlDbType.NVarChar, 50);
            p[1].Value = pat_tc;
            p[2] = new SqlParameter("@staff_name", SqlDbType.NVarChar, 50);
            p[2].Value = pat_nam;
            p[3] = new SqlParameter("@staff_age", SqlDbType.Int);
            p[3].Value = pat_age;
            p[4] = new SqlParameter("@staff_gender", SqlDbType.NVarChar, 50);
            p[4].Value = gen;
            p[5] = new SqlParameter("@staff_phone", SqlDbType.NVarChar, 50);
            p[5].Value = pho;
           
            p[6] = new SqlParameter("@staff_date", SqlDbType.Date);
            p[6].Value = dat;
            p[7] = new SqlParameter("@staff_email", SqlDbType.NVarChar, 50);
            p[7].Value = emi;
           
            ob.RUA("update_staff_info", p);
            ob.close();
        }
        public void Delete_staffs_info(string sat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@s_ID", SqlDbType.Int);
            p[0].Value = sat_id;
            ob.RUA("delete_staff_info", p);
            ob.close();
        }

        public DataTable search_staff_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_staff_date", p);
            ob.close();
            return dt;
        }
    }
}
