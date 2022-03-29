using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.TeacherService
{
    public class TeacherService:ITeacherService
    {
        private AttendanceManagement db = new AttendanceManagement();
        public List<Teacher>  GetTeachers()
        {
            List<Teacher> Teachers = db.TeacherModel.ToList();
            return Teachers;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = db.TeacherModel.Where(t => t.Id == id).FirstOrDefault();  
            return teacher;
        }
        public string AddTeacher(Teacher Teacher)
        {
            Teacher t = new Teacher();
            t.Name = Teacher.Name;
            t.Subject = Teacher.Subject;
            t.Class = Teacher.Class;

            db.TeacherModel.Add(t);
            db.SaveChanges();
            return "Teacher Added Successfull";
        }

        public string UpdateTeacher(Teacher Teacher)
        {
            try
            {
                Teacher t = db.TeacherModel.Where(tmp => tmp.Id == Teacher.Id).FirstOrDefault();
                t.Name = Teacher.Name;
                t.Subject = Teacher.Subject;
                t.Class = Teacher.Class;
                //db.Entry(Teacher).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Teacher Updated Successfully!!";
            }catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "Something went wrong";
            }
            
        }

        public String DeleteTeacher(int id)
        {
            var t = db.TeacherModel.Where(tmp => id == tmp.Id).FirstOrDefault();
            db.TeacherModel.Remove(t);
            db.SaveChanges();
            return "Teacher Deleted Successfully";
        }
    }
}
