namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedia')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Accion')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
