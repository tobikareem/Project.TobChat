namespace Project.TobChat.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentMajor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ScheduleId", "dbo.Schedules");
            DropIndex("dbo.Students", new[] { "ScheduleId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropColumn("dbo.Students", "Major");
            RenameColumn(table: "dbo.Students", name: "DepartmentId", newName: "Major");
            AlterColumn("dbo.Students", "Major", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Major");
            DropColumn("dbo.Students", "ScheduleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ScheduleId", c => c.Int(nullable: false));
            DropIndex("dbo.Students", new[] { "Major" });
            AlterColumn("dbo.Students", "Major", c => c.String());
            RenameColumn(table: "dbo.Students", name: "Major", newName: "DepartmentId");
            AddColumn("dbo.Students", "Major", c => c.String());
            CreateIndex("dbo.Students", "DepartmentId");
            CreateIndex("dbo.Students", "ScheduleId");
            AddForeignKey("dbo.Students", "ScheduleId", "dbo.Schedules", "Id", cascadeDelete: true);
        }
    }
}
