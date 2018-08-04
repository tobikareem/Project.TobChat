namespace Project.TobChat.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDeptInstrRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            AddColumn("dbo.Departments", "Adminstrator", c => c.String());
            AddColumn("dbo.Instructors", "DepartmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Instructors", "DepartmentId");
            CreateIndex("dbo.Students", "DepartmentId");
            AddForeignKey("dbo.Instructors", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: false);
            DropColumn("dbo.Departments", "InstructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "InstructorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Instructors", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Instructors", new[] { "DepartmentId" });
            DropColumn("dbo.Students", "DepartmentId");
            DropColumn("dbo.Instructors", "DepartmentId");
            DropColumn("dbo.Departments", "Adminstrator");
            CreateIndex("dbo.Departments", "InstructorId");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
        }
    }
}
