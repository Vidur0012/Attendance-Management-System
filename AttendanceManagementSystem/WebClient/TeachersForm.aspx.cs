using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TeachersForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdminService.AdminServiceClient asc = new AdminService.AdminServiceClient();
            Label1.Text = asc.AdminLogin("admin", "admin1234");
        }
    }
}