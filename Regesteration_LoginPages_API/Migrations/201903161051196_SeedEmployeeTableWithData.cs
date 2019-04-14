namespace Regesteration_LoginPages_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEmployeeTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (FirstName, LastName, Gender , Salary) VALUES ('Karim' , 'Alaa' , 'Male' , 4350)");
            Sql("INSERT INTO Employees (FirstName, LastName, Gender , Salary) VALUES ('Doaa' , 'Ahmed' , 'Female' , 4000)");
            Sql("INSERT INTO Employees (FirstName, LastName, Gender , Salary) VALUES ('Ramzy' , 'Ahmed' , 'Male' , 3000)");
            Sql("INSERT INTO Employees (FirstName, LastName, Gender , Salary) VALUES ('Hadeer' , 'Ezzat' , 'Female' , 2000)");
        }
        
        public override void Down()
        {
        }
    }
}
