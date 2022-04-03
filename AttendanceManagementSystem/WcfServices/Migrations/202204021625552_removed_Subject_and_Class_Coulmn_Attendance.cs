namespace WcfServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removed_Subject_and_Class_Coulmn_Attendance : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Attendances", "Class");
            DropColumn("dbo.Attendances", "Subject");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendances", "Subject", c => c.String());
            AddColumn("dbo.Attendances", "Class", c => c.Int(nullable: false));
        }
    }
}
