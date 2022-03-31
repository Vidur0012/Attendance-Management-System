using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Enabled = false;
            TeacherService.TeacherServiceClient ts = new TeacherService.TeacherServiceClient();
            TeacherService.Teacher[] tl =   ts.GetTeachers();
            teacherlist.DataSource =  tl;
            teacherlist.DataTextField = "Name";
            teacherlist.DataValueField = "Id";
            teacherlist.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdminService.AdminServiceClient asc = new AdminService.AdminServiceClient();
            string u_name = TextBox1.Text.ToString().ToLower();
            string password = TextBox2.Text.ToString().ToLower();
            string validate = asc.AdminLogin(u_name,password);
            if (validate == "success")
            {
                Label1.Text = "";
                Response.Redirect("/AdminPage.aspx");
            }
            else
            {
                Label1.Text = "Invalid Login Attempt";
                Label1.Enabled=true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}