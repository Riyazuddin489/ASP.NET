namespace MovieAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Name) values('Action')");
            Sql("insert into Genres(Name) values('Comedy')");
            Sql("insert into Genres(Name) values('Crime')");
            Sql("insert into Genres(Name) values('Drama')");
            Sql("insert into Genres(Name) values('Fantasy')");
            Sql("insert into Genres(Name) values('Historical')");
            Sql("insert into Genres(Name) values('Horror')");
            Sql("insert into Genres(Name) values('Mystery')");
            Sql("insert into Genres(Name) values('Philosophical')");
            Sql("insert into Genres(Name) values('Political')");
            Sql("insert into Genres(Name) values('Romance')");
            Sql("insert into Genres(Name) values('Science fiction')");
            Sql("insert into Genres(Name) values('Thriller')");
        }

        public override void Down()
        {
            Sql("delete from Genres where Id=1");
            Sql("delete from Genres where Id=2");
            Sql("delete from Genres where Id=3");
            Sql("delete from Genres where Id=4");
            Sql("delete from Genres where Id=5");
            Sql("delete from Genres where Id=6");
            Sql("delete from Genres where Id=7");
            Sql("delete from Genres where Id=8");
            Sql("delete from Genres where Id=9");
            Sql("delete from Genres where Id=10");
            Sql("delete from Genres where Id=11");
            Sql("delete from Genres where Id=12");
            Sql("delete from Genres where Id=13");
        }
    }
}
