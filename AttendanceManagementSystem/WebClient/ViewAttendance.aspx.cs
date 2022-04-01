using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static TeacherService.Teacher teacher;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedTeacher"] != null)
            {
                teacher = Session["SelectedTeacher"] as TeacherService.Teacher;

            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(TextBox1.Text);


        }
    }
}