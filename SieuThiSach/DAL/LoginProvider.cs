using SieuThiSach.SO;
using SieuThiSach.SystemForm;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiSach.DAL
{
    class LoginProvider
    {
        #region Login vào ứng dụng
        public static string LoginApp(
            string host, string port, string servicename, string userdb, string pwddb,
            string username, string password)
        {
            string result = "Lỗi đăng nhập.";
            DataAccess dbA = new DataAccess();
            MyApp.MSSQLConnectionString = MyApp.GetLoginMSSQL(host, servicename, userdb, pwddb);
            //dbA.ConnectionString = MyApp.MSSQLConnectionString;
            string sql = "SELECT code From [User] WHERE code='" + username + "' and SDUNG = 'C'";
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            try
            {
                DbDataReader reader = dbA.ExecuteAsDataReaderSql(sql, ParaMeterCollection);
                if (reader.Read()) result = "true";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        #endregion
    }
}
