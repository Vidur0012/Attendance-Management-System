namespace WcfServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Password_In_Teacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Password");
        }
    }
}
