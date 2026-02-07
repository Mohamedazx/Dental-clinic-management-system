using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dentist1;

namespace dintist.DL
{
    class login 
    {
        public DataTable Mlogin(string user_name, string user_password,string type)
        {
            DXL ob = new DXL();
            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@usernm", SqlDbType.NVarChar, 50);
            p[0].Value = usernm;
            p[1] = new SqlParameter("@passwrd", SqlDbType.NVarChar, 50);
            p[1].Value = user_password;
            p[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            p[2].Value = type;
            ob.open();
            dt = ob.Reader("Mlogin", p);
            ob.close();
            return dt;
        }

       
    }
}
