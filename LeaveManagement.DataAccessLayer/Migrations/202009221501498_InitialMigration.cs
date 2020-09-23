namespace LeaveManagement.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        DateOfJoining = c.DateTime(storeType: "date"),
                        Designation = c.String(maxLength: 50),
                        PriorExperience = c.Int(),
                        Email = c.String(nullable: false, maxLength: 50),
                        CurrentAddress = c.String(maxLength: 250),
                        PermanentAddress = c.String(maxLength: 250),
                        CountryId = c.Int(nullable: false),
                        DOB = c.DateTime(storeType: "date"),
                        Gender = c.String(maxLength: 25),
                        MaritalStatus = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.EmployeeEducation",
                c => new
                    {
                        EmpEduId = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        EducationTypeId = c.Int(nullable: false),
                        Institution = c.String(maxLength: 100),
                        FromDate = c.DateTime(nullable: false, storeType: "date"),
                        ToDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.EmpEduId)
                .ForeignKey("dbo.EducationType", t => t.EducationTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.EmpId)
                .Index(t => t.EducationTypeId);
            
            CreateTable(
                "dbo.EducationType",
                c => new
                    {
                        EduId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.EduId);
            
            CreateTable(
                "dbo.EmployeeProject",
                c => new
                    {
                        EmpProId = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpProId)
                .ForeignKey("dbo.Employee", t => t.EmpId, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.EmpId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeProject", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.EmployeeProject", "EmpId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeEducation", "EmpId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeEducation", "EducationTypeId", "dbo.EducationType");
            DropForeignKey("dbo.Employee", "CountryId", "dbo.Country");
            DropIndex("dbo.EmployeeProject", new[] { "ProjectId" });
            DropIndex("dbo.EmployeeProject", new[] { "EmpId" });
            DropIndex("dbo.EmployeeEducation", new[] { "EducationTypeId" });
            DropIndex("dbo.EmployeeEducation", new[] { "EmpId" });
            DropIndex("dbo.Employee", new[] { "CountryId" });
            DropTable("dbo.Project");
            DropTable("dbo.EmployeeProject");
            DropTable("dbo.EducationType");
            DropTable("dbo.EmployeeEducation");
            DropTable("dbo.Employee");
            DropTable("dbo.Country");
        }
    }
}
