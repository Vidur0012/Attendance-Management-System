using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Enabled = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/StudentsAndTeachers.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TeacherService.TeacherServiceClient ts = new TeacherService.TeacherServiceClient();
            TeacherService.Teacher t = new TeacherService.Teacher();
            t.Name = Tname.Text;
            t.Class = Int32.Parse( tclass.SelectedValue);
            t.Subject = subject.Text;
            string response = ts.AddTeacher(t);
            Label1.Enabled=true;
            Label1.Text = response;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient sc = new StudentService.StudentServiceClient();
            StudentService.Student s = new StudentService.Student();
            s.Name = Sname.Text;
            s.RollNo = Int32.Parse(rollno.Text);
            s.Class = Int32.Parse(DropDownList1.SelectedValue);
            string response = sc.AddStudent(s);
            Label1.Enabled = true;
            Label1.Text=response;


        }
    }
}