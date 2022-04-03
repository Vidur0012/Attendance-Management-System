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
        public class AttendanceEntry
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int RollNo { get; set; }
            public bool Present { get; set; }
            public AttendanceEntry(int id, string name, int rollno, bool present)
            {
                Id = id;
                Name = name;
                RollNo = rollno;
                Present = present;
            }
        }

        public static TeacherService.Teacher teacher;
        public List<AttendanceService.Attendance> attendance_list;
        StudentService.Student[] stu_list;

        public List<AttendanceEntry> AttendanceEntries = new List<AttendanceEntry>();
        
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
            AttendanceService.AttendanceServiceClient asc = new AttendanceService.AttendanceServiceClient();
            attendance_list =  asc.GetAllAttendanceByTeacherAndDate(teacher.Id, date).ToList();
            stu_list = Session["student_list"] as StudentService.Student[];

            for(int i=0; i<attendance_list.Count; i++)
            {
                AttendanceEntries.Add(new AttendanceEntry(stu_list[i].Id, stu_list[i].Name, stu_list[i].RollNo, attendance_list[i].Present));
            }
        }
    }
}