using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServices.AdminService
{
    public class AdminService : IAdminService
    {
        private AttendanceManagement db = new AttendanceManagement();

        public string AdminLogin(string username, string password)
        {
            Admin admin = db.AdminModel.Where(a => a.Username == username && a.password==password).FirstOrDefault();
            if(admin!=null)
            {
                return "success";
            }
            else
            {
                return "failure";
            }
        }
       
    }
}

