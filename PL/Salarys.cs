using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dentist1;

namespace dintist.PL
{
    class Salarys
    {
        public void new_salary(int salary_id,string staff_name,
          string salary,
          string Incentives,
          DateTime date,
          string total)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@salary_id", SqlDbType.Int);
            p[0].Value = salary_id;
            p[1] = new SqlParameter("@staff_name", SqlDbType.NVarChar,50);
            p[1].Value = staff_name;
            p[2] = new SqlParameter("@salary", SqlDbType.Int);
            p[2].Value = salary;
            p[3] = new SqlParameter("@Incentives", SqlDbType.Int);
            p[3].Value = Incentives;
            p[4] = new SqlParameter("@date", SqlDbType.Date);
            p[4].Value = date;
            p[5] = new SqlParameter("@Total_Salary", SqlDbType.Int);
            p[5].Value = total;

            ob.RUA("new_salarys", p);
            ob.close();
        }

        public DataTable search_salary_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_salary_date", p);
            ob.close();
            return dt;
        }
        public DataTable show_salary_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_salary_id", null);
            ob.close();
            return dt;
        }

        public DataTable view_all_salarys()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_salarys", null);
            ob.close();
            return dt;
        }
        public void delete_salary_info(int bill_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = bill_id;
            ob.RUA("delete_salary_info", p);
            ob.close();
        }
    }
}
