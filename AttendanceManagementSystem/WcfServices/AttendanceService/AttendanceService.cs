using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.AttendanceService
{
    public class AttendanceService : IAttendanceService
    {
        private AttendanceManagement db = new AttendanceManagement();

        public string AddAttendances(List<int> sids, List<bool> presents, int tid, DateTime dt)
        {
            try
            {
                IEnumerable<Attendance> x = GetAllAttendanceByTeacherAndDate(tid, dt);
                int count = x.Count();
                if (count >0 )
                {
                    return "Attendance Already Taken";
                }
                TeacherService.Teacher t = db.TeacherModel.Find(tid);
                for (int i = 0; i < sids.Count; i++)
                {
                    StudentService.Student s = db.StudentModel.Find(sids[i]);
                    Attendance a = new Attendance();
                    a.S = s;
                    a.T = t;
                    a.Date = dt.Date;
                    a.Present = presents[i];
                    db.AttendanceModel.Add(a);
                    db.SaveChanges();
                }
                return "Attendance Taken Succesfully.";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                return "Something went wrong!";
            }
        }
       
        public IEnumerable<Attendance> GetAllAttendanceByTeacherAndDate(int tid, DateTime dt)
        {
            IEnumerable<Attendance> lst = from a in db.AttendanceModel where a.T.Id == tid && a.Date ==dt select a;
            return lst;
        }
        public IEnumerable<Attendance> GetAllAttendanceByStudentAndTeacher(int sid, int tid)
        {
            IEnumerable<Attendance> lst = from a in db.AttendanceModel where a.T.Id == tid && a.S.Id == sid select a;
            return lst;
        }
    }
}
