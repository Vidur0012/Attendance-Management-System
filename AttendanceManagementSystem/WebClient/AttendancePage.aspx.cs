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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedTeacher"] != null)
            {
                if(!IsPostBack)
                {
                    TeacherService.TeacherServiceClient ts = new TeacherService.TeacherServiceClient();
                    int Class = ts.GetTeacher(Int32.Parse(Session["selectedTeacher"].ToString())).Class;

                    StudentService.StudentServiceClient student = new StudentService.StudentServiceClient();
                    stu_list =  student.GetStudentByClass(Class);
                    //for(int i = 0; i < stu_list.Length; i++)
                    //{
                    //    CheckBoxList1.Items.Add("Present");
                    //}

                    DataTable dt = new DataTable();
                    dt.Columns.Add("NO");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Rollno");;
                    for (int i = 0;i< stu_list.Length; i++)
                    {
                        dt.Rows.Add(stu_list[i].Id,stu_list[i].Name,stu_list[i].RollNo);
                        

                    }
                    
                    gvData.DataSource = dt;
                    gvData.DataBind();


                    //for (int j = 0; j < stu_list.Length; j++)
                    //{
                    //    HtmlTableRow row = new HtmlTableRow();
                    //    for (int i = 0; i < 4; i++)
                    //    {
                    //        HtmlTableCell cell = new HtmlTableCell();
                    //        cell.Init
                    //        row.Cells.Add()
                    //        RadioButton radioButton = new RadioButton();
                    //        radioButton.Text = "Text " + i.ToString();
                    //        cell.Controls.Add(radioButton);
                    //        row.Cells.Add(cell);
                    //    }
                    //    table1.Rows.Add(row);
                    //}

                }
            }

        }
    }
}