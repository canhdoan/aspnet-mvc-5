namespace AspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Hangover', 5)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Die Hard', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('The Terminator', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Toy Story', 3)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Titanic', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
