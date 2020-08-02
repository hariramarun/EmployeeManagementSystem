namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeeManagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        EmailId = c.String(),
                        MobileNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeDetails");
        }
    }
}
