using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.AdminService
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        string AdminLogin(string username, string password);

    }
}
