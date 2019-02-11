namespace MovieAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie : DbMigration
    {
        public override void Up()
        {

            Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Hitman Bodygaurd','2000-03-11','Action movies',5,1)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Why him','2018-04-21','comedy movies',2,2)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Twilight','2000-05-11','Romantic movies',3,11)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Harry Potter','2020-06-11','Fantasy movies',5,5)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Intersteller','2010-07-11','science fiction movies',4,12)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Mission impossible','2007-08-11','Thriller movies',4,13)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Gandhi','2008-09-11','political movies',4,10)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('conjuring','2009-02-11','Horror movies',4,7)");
        Sql("insert into Movies(Name,DateReleased,Description,Rating,Genre_Id) values('Black Panther','2000-01-11','sci-fi movies',4,12)");

    }

    public override void Down()
    {
        Sql("delete from Movies where Id=1");
        Sql("delete from Movies where Id=2");
        Sql("delete from Movies where Id=3");
        Sql("delete from Movies where Id=4");
        Sql("delete from Movies where Id=5");
        Sql("delete from Movies where Id=6");
        Sql("delete from Movies where Id=7");
        Sql("delete from Movies where Id=8");
        Sql("delete from Movies where Id=9");

    }
}
}
