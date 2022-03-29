namespace WcfServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attendanceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Subject = c.String(),
                        Present = c.Boolean(nullable: false),
                        S_Id = c.Int(),
                        T_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.S_Id)
                .ForeignKey("dbo.Teachers", t => t.T_Id)
                .Index(t => t.S_Id)
                .Index(t => t.T_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "T_Id", "dbo.Teachers");
            DropForeignKey("dbo.Attendances", "S_Id", "dbo.Students");
            DropIndex("dbo.Attendances", new[] { "T_Id" });
            DropIndex("dbo.Attendances", new[] { "S_Id" });
            DropTable("dbo.Attendances");
        }
    }
}
