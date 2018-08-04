namespace Project.TobChat.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDeptAdminNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Adminstrator", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "Adminstrator");
            AddForeignKey("dbo.Departments", "Adminstrator", "dbo.People", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Adminstrator", "dbo.People");
            DropIndex("dbo.Departments", new[] { "Adminstrator" });
            AlterColumn("dbo.Departments", "Adminstrator", c => c.String());
        }
    }
}
