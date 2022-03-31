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
                TeacherService.TeacherServiceClient ts = new TeacherService.TeacherServiceClient();
                TeacherService.Teacher[] tl =   ts.GetTeachers();
                DropDownList1.DataSource =  tl;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.SelectedIndex = 0;
                DropDownList1.DataBind();
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
                Label1.Text = "";
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
            Response.Redirect("AttendancePage.aspx");
        }

       

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedTeacher"] =  DropDownList1.SelectedItem.Value;
        }
    }
}