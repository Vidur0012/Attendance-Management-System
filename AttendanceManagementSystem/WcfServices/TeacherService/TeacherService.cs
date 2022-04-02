using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.TeacherService
{
    public class TeacherService : ITeacherService
    {
        private AttendanceManagement db = new AttendanceManagement();
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = db.TeacherModel.ToList();
            return teachers;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = db.TeacherModel.Where(t => t.Id == id).FirstOrDefault();
            return teacher;
        }
        public string AddTeacher(Teacher teacher)
        {
            try
            {
                Teacher t_tmp = (from ts in db.TeacherModel where ts.Class == teacher.Class && ts.Subject.ToLower() == teacher.Subject.ToLower() select ts).FirstOrDefault();
                if(t_tmp != null)
                {
                    return "Duplicate";
                }
                Teacher t = new Teacher();
                t.Name = teacher.Name;
                t.Subject = teacher.Subject;
                t.Class = teacher.Class;

                db.TeacherModel.Add(t);
                db.SaveChanges();
                return "Teacher Added Successfull";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);

                return "Something went wrong!";
            }
        }

        public string UpdateTeacher(Teacher teacher)
        {
            try
            {
                Teacher t = db.TeacherModel.Where(o => o.Id == teacher.Id).FirstOrDefault();
                t.Name = teacher.Name;
                t.Subject = teacher.Subject;
                t.Class = teacher.Class;
                db.SaveChanges();
                return "Teacher Updated Successfully!!";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);

                return "Something went wrong!";
            }

        }

        public String DeleteTeacher(int id)
        {
            try
            {
                Teacher t = db.TeacherModel.Where(o => o.Id == id).FirstOrDefault();
                db.TeacherModel.Remove(t);
                db.SaveChanges();
                return "Teacher Deleted Successfully";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);

                return "Something went wrong!";
            }
        }
    }
}
