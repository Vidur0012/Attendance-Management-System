using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.AttendanceService
{
    [DataContract]
    public class Attendance
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Class { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public bool Present { get; set; }
        [DataMember]
        public TeacherService.Teacher T { get; set; }
        [DataMember]
        public StudentService.Student S { get; set; }
    }
}
