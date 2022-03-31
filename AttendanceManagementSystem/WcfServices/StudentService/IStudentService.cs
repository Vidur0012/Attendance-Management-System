using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WcfServices.StudentService
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<Student> GetStudents();
        [OperationContract]
        List<Student> GetStudentByClass(int cid);

        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        string AddStudent(Student student);

        [OperationContract]
        string DeleteStudent(int id);

        [OperationContract]
        string UpdateStudent(Student student);

    }
}
