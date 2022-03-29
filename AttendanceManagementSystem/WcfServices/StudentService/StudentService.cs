using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.StudentService
{
    public class StudentService : IStudentService
    {
        private AttendanceManagement db = new AttendanceManagement();
        public List<Student> GetStudents()
        {
            List<Student> students = db.StudentModel.ToList();
            return students;
        }

        public Student GetStudent(int id)
        {
            Student student = db.StudentModel.Where(s => s.Id == id).FirstOrDefault();
            return student;
        }
        public string AddStudent(Student student)
        {
            try
            {
                Student s = new Student();
                s.Name = student.Name;
                s.Class = student.Class;
                s.RollNo = student.RollNo;

                db.StudentModel.Add(s);
                db.SaveChanges();
                return "Student Added Successfull";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong!";
            }
        }

        public string UpdateStudent(Student student)
        {
            try
            {
                Student s = db.StudentModel.Where(o => o.Id == student.Id).FirstOrDefault();
                s.Name = student.Name;
                s.Class = student.Class;
                s.RollNo = student.RollNo;

                db.SaveChanges();
                return "Student Updated Successfully!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong!";
            }

        }

        public String DeleteStudent(int id)
        {
            try
            {
                Student s = db.StudentModel.Where(o => o.Id == id).FirstOrDefault();
                db.StudentModel.Remove(s);
                db.SaveChanges();
                return "Student Deleted Successfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong!";
            }
        }
    }
}
