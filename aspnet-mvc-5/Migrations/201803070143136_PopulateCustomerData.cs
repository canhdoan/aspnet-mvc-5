namespace aspnet_mvc_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, MembershipTypeId, IsSubscribedToNewsLetter) VALUES ('John Smith', 1, 'False')");
            Sql("INSERT INTO Customers (Name, MembershipTypeId, IsSubscribedToNewsLetter) VALUES ('Mary Williams', 2, 'True')");
        }
        
        public override void Down()
        {
        }
    }
}
