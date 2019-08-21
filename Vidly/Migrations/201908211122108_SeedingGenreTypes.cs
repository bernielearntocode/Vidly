namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into GenreTypes Values (1, 'Comedy')");
            Sql("Insert into GenreTypes Values (2, 'Action')");
            Sql("Insert into GenreTypes Values (3, 'Family')");
            Sql("Insert into GenreTypes Values (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
