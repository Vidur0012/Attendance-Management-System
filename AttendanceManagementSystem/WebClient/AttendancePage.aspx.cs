using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class AttendancePage : System.Web.UI.Page
    {
        public StudentService.Student[] stu_list;
        public static TeacherService.Teacher teacher;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedTeacher"] != null)
            {
                teacher = Session["SelectedTeacher"] as TeacherService.Teacher;
                int Class = teacher.Class;

                StudentService.StudentServiceClient student = new StudentService.StudentServiceClient();
                stu_list = student.GetStudentByClass(Class);
                Session["student_list"] = stu_list;
                Label1.Visible = false;

                if(!IsPostBack)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("NO");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Rollno");;
                    for (int i = 0;i< stu_list.Length; i++)
                    {
                        dt.Rows.Add(stu_list[i].Id,stu_list[i].Name,stu_list[i].RollNo);
                        

                    }
                    if(stu_list.Length == 0)
                    {
                        Label1.Text = "There is no students Found!";
                       Label1.Visible=true;
                        Button1.Enabled = false;
                    }
                    gvData.DataSource = dt;
                    gvData.DataBind();
                }
            }
            else
            {
                Response.Redirect("/HomePage.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //List<int> sids, List< bool > presents, int tid, DateTime dt, int cls, string sub
            List<int> student_list = stu_list.Select(s => s.Id).ToList();
            int t_id = teacher.Id;
            int cid = teacher.Class;
            string sub = teacher.Subject;
            DateTime date = DateTime.Now;
            List<bool> present = new List<bool>();
            foreach (GridViewRow gvrow in gvData.Rows)
            {
                var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                if (checkbox.Checked)
                {
                    present.Add(true);
                }
                else
                {
                    present.Add(false);
                }
            }
           
           Label1.Visible = true;
            AttendanceService.AttendanceServiceClient asc = new AttendanceService.AttendanceServiceClient();
            Label1.Text =  asc.AddAttendances(student_list.ToArray(),present.ToArray(),t_id,date,cid,sub );

        }
    }
}