namespace Project.TobChat.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Instructors", new[] { "Course_Id" });
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_Id, t.Course_Id })
                .ForeignKey("dbo.Instructors", t => t.Instructor_Id, cascadeDelete: false)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: false)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Course_Id);
            
            AddColumn("dbo.Courses", "Credit", c => c.Double(nullable: false));
            AddColumn("dbo.Students", "ScheduleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ScheduleId");
            AddForeignKey("dbo.Students", "ScheduleId", "dbo.Schedules", "Id", cascadeDelete: false);
            DropColumn("dbo.Instructors", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructors", "Course_Id", c => c.Int());
            DropForeignKey("dbo.Students", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.InstructorCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropIndex("dbo.InstructorCourses", new[] { "Course_Id" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_Id" });
            DropIndex("dbo.Students", new[] { "ScheduleId" });
            DropColumn("dbo.Students", "ScheduleId");
            DropColumn("dbo.Courses", "Credit");
            DropTable("dbo.InstructorCourses");
            CreateIndex("dbo.Instructors", "Course_Id");
            AddForeignKey("dbo.Instructors", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
