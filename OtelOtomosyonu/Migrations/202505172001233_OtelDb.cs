namespace OtelOtomosyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtelDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customarId = c.Int(nullable: false, identity: true),
                        customarName = c.String(),
                        customarLastname = c.String(),
                        customarAge = c.Int(nullable: false),
                        roomType = c.String(),
                        dayOfEntry = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.customarId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeId = c.Int(nullable: false, identity: true),
                        employeeName = c.String(),
                        employeeLastname = c.String(),
                        employeeAge = c.Int(nullable: false),
                        employeeSection = c.String(),
                    })
                .PrimaryKey(t => t.employeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
