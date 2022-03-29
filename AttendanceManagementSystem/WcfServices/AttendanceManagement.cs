using System;
using System.Data.Entity;
using System.Linq;

namespace WcfServices
{
    public class AttendanceManagement : DbContext
    {
        // Your context has been configured to use a 'AttendanceManagement' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WcfServices.AttendanceManagement' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AttendanceManagement' 
        // connection string in the application configuration file.
        public AttendanceManagement()
            : base("name=AttendanceManagement")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<TeacherService.Teacher> TeacherModel { get; set; }
        public virtual DbSet<AdminService.Admin> AdminModel { get; set; }
        public virtual DbSet<StudentService.Student> StudentModel { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}