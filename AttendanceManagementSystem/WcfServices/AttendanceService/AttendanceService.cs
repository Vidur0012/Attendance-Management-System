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

        public string AddAttendances(List<int> sids, List<bool> presents, int tid, DateTime dt, int cls, string sub)
        {
            try
            {
                TeacherService.Teacher t = db.TeacherModel.Find(tid);
                for (int i = 0; i < sids.Count; i++)
                {
                    StudentService.Student s = db.StudentModel.Find(sids[i]);
                    Attendance a = new Attendance();
                    a.S = s;
                    a.T = t;
                    a.Class = cls;
                    a.Subject = sub;
                    a.Date = dt;
                    a.Present = presents[i];
                    db.AttendanceModel.Add(a);
                    db.SaveChanges();
                }
                return "Attendance Taken Succesfully.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Something went wrong!";
            }
        }
        public IEnumerable<Attendance> GetAllAttendanceByTeacher(int tid)
        {
            IEnumerable<Attendance> lst = from a in db.AttendanceModel where a.T.Id == tid select a;
            
            return lst;
        }
        public IEnumerable<Attendance> GetAllAttendanceByDate(DateTime dt)
        {
            IEnumerable<Attendance> lst = from a in db.AttendanceModel where a.Date == dt select a;
            return lst;
        }
        public IEnumerable<Attendance> GetAllAttendanceByTeacherAndDate(int tid, DateTime dt)
        {
            IEnumerable<Attendance> lst = from a in db.AttendanceModel where a.T.Id == tid select a;
            Func<Attendance, bool> filt = x =>
             {
                 DateTime d = x.Date;
                 if (d.Date == dt.Date)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             };
            lst = lst.Where(filt);
            return lst;
        }
    }
}
