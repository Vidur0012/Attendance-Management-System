using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class StudentsAndTeachers : System.Web.UI.Page
    {
        public int StudentIndex = 0;
        public int TeacherIndex = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                StudentService.StudentServiceClient ssc = new StudentService.StudentServiceClient();
                StudentService.Student[] StudentList = ssc.GetStudents();
                DataTable students = new DataTable();
                students.Columns.Add("Id");
                students.Columns.Add("Name");
                students.Columns.Add("Class");
                students.Columns.Add("RollNo");

                for (int i = 0; i < StudentList.Length; i++)
                {
                    students.Rows.Add(StudentList[i].Id, StudentList[i].Name, StudentList[i].Class, StudentList[i].RollNo);
                }
                ViewState["students"] = students;
                BindGridStudent();

                TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
                TeacherService.Teacher[] TeacherList = tsc.GetTeachers();

                DataTable teachers = new DataTable();
                teachers.Columns.Add("Id");
                teachers.Columns.Add("Name");
                teachers.Columns.Add("Class");
                teachers.Columns.Add("Subject");

                for (int i = 0; i < TeacherList.Length; i++)
                {
                    teachers.Rows.Add(TeacherList[i].Id, TeacherList[i].Name, TeacherList[i].Class, TeacherList[i].Subject);
                }
                ViewState["teachers"] = teachers;
                BindGridTeacher();

            }
        }
        protected void BindGridStudent()
        {
            GridViewStudent.DataSource = ViewState["students"] as DataTable;
            GridViewStudent.DataBind();
        }
        protected void BindGridTeacher()
        {
            GridViewTeacher.DataSource = ViewState["teachers"] as DataTable;
            GridViewTeacher.DataBind();
        }
        protected void GridViewStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewStudent.EditIndex = e.NewEditIndex;
            BindGridStudent();
        }
        protected void GridViewTeacher_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTeacher.EditIndex = e.NewEditIndex;
            BindGridTeacher();
        }
        protected void OnUpdateStudent(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable students = ViewState["students"] as DataTable;

            int StudentId = Convert.ToInt32(students.Rows[row.RowIndex]["Id"]);
            string StudentName = ((TextBox)row.Cells[1].Controls[0]).Text;
            int StudentClass = Convert.ToInt32(((TextBox)row.Cells[2].Controls[0]).Text);
            int StudentRollNo = Convert.ToInt32(((TextBox)row.Cells[3].Controls[0]).Text);

            StudentService.StudentServiceClient sc = new StudentService.StudentServiceClient();
            StudentService.Student s = new StudentService.Student();
            s.Id = StudentId;
            s.Name = StudentName;
            s.Class = StudentClass;
            s.RollNo = StudentRollNo;

            string resp = sc.UpdateStudent(s);
            if(resp== "Student Updated Successfully!!")
            {
                students.Rows[row.RowIndex]["Name"] = StudentName;
                students.Rows[row.RowIndex]["Class"] = StudentClass;
                students.Rows[row.RowIndex]["RollNo"] = StudentRollNo;
                ViewState["students"] = students;
            }
            GridViewStudent.EditIndex = -1;
            BindGridStudent();
        }
        protected void OnUpdateTeacher(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable teachers = ViewState["teachers"] as DataTable;

            int TeacherId = Convert.ToInt32(teachers.Rows[row.RowIndex]["Id"]);
            string TeacherName = ((TextBox)row.Cells[1].Controls[0]).Text;
            int TeacherClass = Convert.ToInt32(((TextBox)row.Cells[2].Controls[0]).Text);
            string TeacherSubject = ((TextBox)row.Cells[3].Controls[0]).Text;

            TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
            TeacherService.Teacher t = new TeacherService.Teacher();
            t.Id = TeacherId;
            t.Name = TeacherName;
            t.Class = TeacherClass;
            t.Subject = TeacherSubject;

            string resp = tsc.UpdateTeacher(t);
            if (resp == "Teacher Updated Successfully!!")
            {
                teachers.Rows[row.RowIndex]["Name"] = TeacherName;
                teachers.Rows[row.RowIndex]["Class"] = TeacherClass;
                teachers.Rows[row.RowIndex]["Subject"] = TeacherSubject;
                ViewState["teachers"] = teachers;
            }
            GridViewTeacher.EditIndex = -1;
            BindGridTeacher();
        }
        protected void OnCancelStudent(object sender, EventArgs e)
        {
            GridViewStudent.EditIndex = -1;
            BindGridStudent();
        }
        protected void OnCancelTeacher(object sender, EventArgs e)
        {
            GridViewTeacher.EditIndex = -1;
            BindGridTeacher();
        }

        protected void OnDeleteStudent(object sender, EventArgs e)
        {
          
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable students = ViewState["students"] as DataTable;

            int StudentId = Convert.ToInt32(students.Rows[row.RowIndex]["Id"]);

            StudentService.StudentServiceClient ssc = new StudentService.StudentServiceClient();
            string resp = ssc.DeleteStudent(StudentId);
            if (resp == "Student Deleted Successfully")
            {
                students.Rows.RemoveAt(row.RowIndex);
            }
            ViewState["students"] = students;
            BindGridStudent();
        }
        protected void OnDeleteTeacher(object sender, EventArgs e)
        {

            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable teachers = ViewState["teachers"] as DataTable;

            int TeacherId = Convert.ToInt32(teachers.Rows[row.RowIndex]["Id"]);

            TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
            string resp = tsc.DeleteTeacher(TeacherId);
            if (resp == "Teacher Deleted Successfully")
            {
                teachers.Rows.RemoveAt(row.RowIndex);
            }
            ViewState["teachers"] = teachers;
            BindGridTeacher();
        }
    }
}