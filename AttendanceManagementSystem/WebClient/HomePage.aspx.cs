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
            if (!IsPostBack)
            {
                Label1.Visible = false;
                Label2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            AdminService.AdminServiceClient asc = new AdminService.AdminServiceClient();
            string u_name = TextBox1.Text.ToString().ToLower();
            string password = TextBox2.Text.ToString().ToLower();
            string validate = asc.AdminLogin(u_name,password);
            if (validate == "success")
            {
                Session["admin"] = true;
                Response.Redirect("/AdminPage.aspx");
            }
            else
            {
                Label1.Text = "Invalid Login Attempt";
                Label1.Visible=true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
            int cls = Int32.Parse(tclass.SelectedValue);
            string sub = TextBox3.Text.ToString();
            string pass = TextBox4.Text.ToString();
            var resp = tsc.TeacherLogin(cls,sub,pass);
            if(resp!=null)
            {
                Session["SelectedTeacher"] = resp;
                Response.Redirect("AttendancePage.aspx");
            }
            else
            {
                Label2.Text = "Invalid Login Attempt";
                Label2.Visible = true;
            }
        }
    }
}