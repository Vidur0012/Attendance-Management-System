using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WcfServices.TeacherService
{
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        List<Teacher> GetTeachers();

        [OperationContract]
        Teacher GetTeacher(int id);

        [OperationContract]
        string AddTeacher(Teacher teacher);

        [OperationContract]
        string DeleteTeacher(int id);

        [OperationContract]
        string UpdateTeacher(Teacher teacher);
        [OperationContract]
        Teacher TeacherLogin(int cls, string subject, string password);
        [OperationContract]

        List<Teacher> GetTeachersByClass(int cls);

    }
}
