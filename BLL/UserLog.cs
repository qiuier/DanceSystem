using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class UserLog
    {
        public static DataTable UserLogIn(string strSql)
        {
            DataTable dt = DAL.DBHelper.GetDt(strSql);
            return dt;
        } 
    }
}
