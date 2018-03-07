namespace aspnet_mvc_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectMisspellingOfCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribdedToNewsLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscribdedToNewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
        }
    }
}
