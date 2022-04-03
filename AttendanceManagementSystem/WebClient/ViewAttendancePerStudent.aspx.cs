using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class ViewAttendancePerStudent : System.Web.UI.Page
    {
        public class AttendanceEntry
        {
            public string TeacherName { get; set; }
            public DateTime Dt { get; set; }

            public bool Present { get; set; }
            public AttendanceEntry(string tname, DateTime dt, bool present)
            {
                TeacherName = tname;
                Dt = dt;
                Present = present;
            }
        }
        public int i;
        public static StudentService.Student student;
        public List<AttendanceService.Attendance> attendance_list;
        TeacherService.Teacher[] tl;
        public List<AttendanceEntry> AttendanceEntries = new List<AttendanceEntry>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedStudent"] != null)
            {
                if (!IsPostBack)
                {

                    student = Session["SelectedStudent"] as StudentService.Student;
                    TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
                    tl = tsc.GetTeachersByClass(student.Class);
                    DropDownList1.DataSource = tl;
                    DropDownList1.DataTextField = "Subject";
                    DropDownList1.DataValueField = "Id";
                    DropDownList1.SelectedIndex = 0;
                    DropDownList1.DataBind();
                    Session["teachers"] = tl;

                    AttendanceService.AttendanceServiceClient asc = new AttendanceService.AttendanceServiceClient();
                    attendance_list = asc.GetAllAttendanceByStudentAndTeacher(student.Id, Int32.Parse(DropDownList1.SelectedItem.Value)).ToList();


                    for (int i = 0; i < attendance_list.Count; i++)
                    {
                        AttendanceEntries.Add(new AttendanceEntry(tl[0].Name, attendance_list[i].Date, attendance_list[i].Present));
                    }
                }
                else
                {
                    tl = Session["teachers"] as TeacherService.Teacher[];
                }


            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttendanceService.AttendanceServiceClient asc = new AttendanceService.AttendanceServiceClient();
            attendance_list = asc.GetAllAttendanceByStudentAndTeacher(student.Id, Int32.Parse(DropDownList1.SelectedItem.Value)).ToList();
            int index = DropDownList1.SelectedIndex;
            string TeacherName = tl[index].Name.ToString();

            for (int i = 0; i < attendance_list.Count; i++)
            {
                AttendanceEntries.Add(new AttendanceEntry(TeacherName, attendance_list[i].Date, attendance_list[i].Present));
            }
        }
    }
}