using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceMetadataBehavior mbehave1 = new ServiceMetadataBehavior();
            mbehave1.HttpGetEnabled = true;
            ServiceMetadataBehavior mbehave2 = new ServiceMetadataBehavior();
            mbehave2.HttpGetEnabled = true;
            ServiceMetadataBehavior mbehave3 = new ServiceMetadataBehavior();
            mbehave3.HttpGetEnabled = true;
            ServiceMetadataBehavior mbehave4 = new ServiceMetadataBehavior();
            mbehave4.HttpGetEnabled = true;

            ServiceHost sh1 = null, sh2 = null, sh3 = null, sh4 = null;

            Uri Uri1 = new Uri("http://localhost:9000/AMSServices/AdminService");
            Uri Uri2 = new Uri("http://localhost:9000/AMSServices/TeacherService");
            Uri Uri3 = new Uri("http://localhost:9000/AMSServices/StudentService");
            Uri Uri4 = new Uri("http://localhost:9000/AMSServices/AttendanceService");

            sh1 = new ServiceHost(typeof(WcfServices.AdminService.AdminService), Uri1);
            sh1.AddServiceEndpoint(typeof(WcfServices.AdminService.IAdminService), new WSHttpBinding(), "");
            sh1.Description.Behaviors.Add(mbehave1);
            sh1.Open();

            sh2 = new ServiceHost(typeof(WcfServices.TeacherService.TeacherService), Uri2);
            sh2.AddServiceEndpoint(typeof(WcfServices.TeacherService.ITeacherService), new WSHttpBinding(), "");
            sh2.Description.Behaviors.Add(mbehave2);
            sh2.Open();

            sh3 = new ServiceHost(typeof(WcfServices.StudentService.StudentService), Uri3);
            sh3.AddServiceEndpoint(typeof(WcfServices.StudentService.IStudentService), new WSHttpBinding(), "");
            sh3.Description.Behaviors.Add(mbehave3);
            sh3.Open();

            sh4 = new ServiceHost(typeof(WcfServices.AttendanceService.AttendanceService), Uri4);
            sh4.AddServiceEndpoint(typeof(WcfServices.AttendanceService.IAttendanceService), new WSHttpBinding(), "");
            sh4.Description.Behaviors.Add(mbehave4);
            sh4.Open();

            Console.WriteLine("All Services Hosted..");
            Console.ReadLine();

            sh1.Close();
            sh2.Close();
            sh3.Close();
            sh4.Close();
        }
    }
}
