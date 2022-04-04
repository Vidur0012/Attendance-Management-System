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
                    return "Teacher Already Exist!";
                }
                Teacher t = new Teacher();
                t.Name = teacher.Name;
                t.Subject = teacher.Subject;
                t.Class = teacher.Class;
                t.Password = teacher.Password;
                db.TeacherModel.Add(t);
                db.SaveChanges();
                return "Teacher Added Successfully.";
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
                Teacher t_tmp = (from ts in db.TeacherModel where ts.Class == teacher.Class && ts.Subject.ToLower() == teacher.Subject.ToLower() select ts).FirstOrDefault();
                if (t_tmp != null && t_tmp.Id != teacher.Id)
                {
                    return "Teacher Already Exist!";
                }
                Teacher t = db.TeacherModel.Where(o => o.Id == teacher.Id).FirstOrDefault();
                t.Name = teacher.Name;
                t.Subject = teacher.Subject;
                t.Class = teacher.Class;
                t.Password = teacher.Password;
                db.SaveChanges();
                return "Teacher Updated Successfully.";
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
                return "Teacher Deleted Successfully.";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);

                return "Something went wrong!";
            }
        }
        public Teacher TeacherLogin(int cls, string subject, string password)
        {
            try
            {
                Teacher t = db.TeacherModel.Where(o => o.Class == cls && o.Subject == subject && o.Password==password ).FirstOrDefault();
                if (t != null)
                    return t;
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Teacher> GetTeachersByClass(int cls)
        {
            List<Teacher> teachers = (from a in db.TeacherModel where a.Class == cls select a).ToList();
            return teachers;
        }
    }
}
