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
        DataTable teachers = new DataTable();
        DataTable students = new DataTable();

        protected void FetchTeachers(int cls)
        {
            TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
            TeacherService.Teacher[] TeacherList = tsc.GetTeachersByClass(cls);

            teachers = new DataTable();
            teachers.Columns.Add("Id");
            teachers.Columns.Add("Name");
            teachers.Columns.Add("Class");
            teachers.Columns.Add("Subject");
            teachers.Columns.Add("Password");

            for (int i = 0; i < TeacherList.Length; i++)
            {
                teachers.Rows.Add(TeacherList[i].Id, TeacherList[i].Name, TeacherList[i].Class, TeacherList[i].Subject, TeacherList[i].Password);
            }
            Session["teachers"] = teachers;
            BindGridTeacher();
        }
        protected void FetchStudents(int cls)
        {
            StudentService.StudentServiceClient ssc = new StudentService.StudentServiceClient();
            StudentService.Student[] StudentList = ssc.GetStudentsByClass(cls);
            students = new DataTable();
            students.Columns.Add("Id");
            students.Columns.Add("Name");
            students.Columns.Add("Class");
            students.Columns.Add("RollNo");

            for (int i = 0; i < StudentList.Length; i++)
            {
                students.Rows.Add(StudentList[i].Id, StudentList[i].Name, StudentList[i].Class, StudentList[i].RollNo);
            }
            Session["students"] = students;
            BindGridStudent();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable students = Session["students"] as DataTable;
            DataTable teachers = Session["teachers"] as DataTable;

            if (!this.IsPostBack || teachers==null || students==null)
            {
                if (Session["SelectedClassStudent"]!=null)
                {
                    FetchStudents(Convert.ToInt32(Session["SelectedClassStudent"]));
                    sclass.SelectedIndex = Convert.ToInt32(Session["SelectedClassStudent"])-1;
                }
                else
                {
                    FetchStudents(Int32.Parse(sclass.SelectedValue));
                    Session["SelectedClassStudent"] = Int32.Parse(sclass.SelectedValue);
                }
                if (Session["SelectedClassTeacher"] != null)
                {
                    FetchTeachers(Convert.ToInt32(Session["SelectedClassTeacher"]));
                    tclass.SelectedIndex = Convert.ToInt32(Session["SelectedClassTeacher"]) - 1;
                }
                else
                {
                    FetchTeachers(Int32.Parse(tclass.SelectedValue));
                    Session["SelectedClassTeacher"] = Int32.Parse(tclass.SelectedValue);
                }
            }
        }
        protected void BindGridStudent()
        {
            GridViewStudent.DataSource = Session["students"] as DataTable;
            GridViewStudent.DataBind();
        }
        protected void BindGridTeacher()
        {
            GridViewTeacher.DataSource = Session["teachers"] as DataTable;
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
            DataTable students = Session["students"] as DataTable;

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
            if(resp== "Student Updated Successfully.")
            {
                students.Rows[row.RowIndex]["Name"] = StudentName;
                students.Rows[row.RowIndex]["Class"] = StudentClass;
                students.Rows[row.RowIndex]["RollNo"] = StudentRollNo;
                Session["students"] = students;
            }
            GridViewStudent.EditIndex = -1;
            BindGridStudent();
            Response.Redirect("StudentsAndTeachers.aspx");

        }
        protected void OnUpdateTeacher(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable teachers = Session["teachers"] as DataTable;

            int TeacherId = Convert.ToInt32(teachers.Rows[row.RowIndex]["Id"]);
            string TeacherName = ((TextBox)row.Cells[1].Controls[0]).Text;
            int TeacherClass = Convert.ToInt32(((TextBox)row.Cells[2].Controls[0]).Text);
            string TeacherSubject = ((TextBox)row.Cells[3].Controls[0]).Text;
            string TeacherPassword = ((TextBox)row.Cells[4].Controls[0]).Text;

            TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
            TeacherService.Teacher t = new TeacherService.Teacher();
            t.Id = TeacherId;
            t.Name = TeacherName;
            t.Class = TeacherClass;
            t.Subject = TeacherSubject;
            t.Password = TeacherPassword;
            string resp = tsc.UpdateTeacher(t);
            if (resp == "Teacher Updated Successfully.")
            {
                teachers.Rows[row.RowIndex]["Name"] = TeacherName;
                teachers.Rows[row.RowIndex]["Class"] = TeacherClass;
                teachers.Rows[row.RowIndex]["Subject"] = TeacherSubject;
                teachers.Rows[row.RowIndex]["Password"] = TeacherPassword;
                Session["teachers"] = teachers;
            }
            GridViewTeacher.EditIndex = -1;
            BindGridTeacher();
            Response.Redirect("StudentsAndTeachers.aspx");

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
            DataTable students = Session["students"] as DataTable;

            try
            {
                int StudentId = Convert.ToInt32(students.Rows[row.RowIndex]["Id"]);
                StudentService.StudentServiceClient ssc = new StudentService.StudentServiceClient();
                string resp = ssc.DeleteStudent(StudentId);

                if (resp == "Student Deleted Successfully.")
                {
                    students.Rows.RemoveAt(row.RowIndex);

                }
                Session["students"] = students;
                BindGridStudent();
                Response.Redirect("StudentsAndTeachers.aspx");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        protected void OnDeleteTeacher(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable teachers = Session["teachers"] as DataTable;
            try
            {
                int TeacherId = Convert.ToInt32(teachers.Rows[row.RowIndex]["Id"]);

                TeacherService.TeacherServiceClient tsc = new TeacherService.TeacherServiceClient();
                string resp = tsc.DeleteTeacher(TeacherId);
                if (resp == "Teacher Deleted Successfully.")
                {
                    teachers.Rows.RemoveAt(row.RowIndex);
                }
                Session["teachers"] = teachers;
                BindGridTeacher();
                Response.Redirect("StudentsAndTeachers.aspx");

            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
        public void ViewAttendanceTeacher(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable teachers = Session["teachers"] as DataTable;
            try
            {
                int TeacherId = Convert.ToInt32(teachers.Rows[row.RowIndex]["Id"]);
                string TeacherName = teachers.Rows[row.RowIndex]["Name"].ToString();
                int TeacherClass = Convert.ToInt32(teachers.Rows[row.RowIndex]["Class"]);
                string TeacherSubject = teachers.Rows[row.RowIndex]["Subject"].ToString();
                string TeacherPassword = teachers.Rows[row.RowIndex]["Password"].ToString();

                TeacherService.Teacher t = new TeacherService.Teacher();
                t.Id = TeacherId;
                t.Name = TeacherName;
                t.Class = TeacherClass;
                t.Subject = TeacherSubject;
                t.Password = TeacherPassword;
                StudentService.StudentServiceClient ssc = new StudentService.StudentServiceClient();
                StudentService.Student[] stu_list = ssc.GetStudentsByClass(TeacherClass);
                Session["student_list"] = stu_list;
                Session["SelectedTeacher"] = t;
                GridViewTeacher.SelectedIndex = -1;

            Response.Redirect("ViewAttendance.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ViewAttendanceStudent(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable students = Session["students"] as DataTable;
            try
            {
                int StudentId = Convert.ToInt32(students.Rows[row.RowIndex]["Id"]);
                string StudentName = students.Rows[row.RowIndex]["Name"].ToString();
                int StudentClass = Convert.ToInt32(students.Rows[row.RowIndex]["Class"]);
                int StudentRollNo = Convert.ToInt32(students.Rows[row.RowIndex]["RollNo"]);

                StudentService.Student s = new StudentService.Student();
                s.Id = StudentId;
                s.Name = StudentName;
                s.Class = StudentClass;
                s.RollNo = StudentRollNo;
                GridViewTeacher.SelectedIndex = -1;

                Session["SelectedStudent"] = s;
                Response.Redirect("ViewAttendancePerStudent.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        protected void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedClassStudent"] = Int32.Parse(sclass.SelectedValue);
            FetchStudents(Int32.Parse(sclass.SelectedValue)); 
        }
        protected void tclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedClassTeacher"] = Int32.Parse(tclass.SelectedValue);
            FetchTeachers(Int32.Parse(tclass.SelectedValue));
        }

    }
}