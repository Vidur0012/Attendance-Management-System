using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.TeacherService
{
    [DataContract]
    public class Teacher
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Class { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
