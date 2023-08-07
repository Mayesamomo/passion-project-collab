namespace AnimeMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animeandgenretable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animes",
                c => new
                    {
                        AnimeID = c.Int(nullable: false, identity: true),
                        AnimeName = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        AnimeHasPic = c.Boolean(nullable: false),
                        PicExtension = c.String(),
                    })
                .PrimaryKey(t => t.AnimeID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                        AnimeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenreID)
                .ForeignKey("dbo.Animes", t => t.AnimeID, cascadeDelete: true)
                .Index(t => t.AnimeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genres", "AnimeID", "dbo.Animes");
            DropIndex("dbo.Genres", new[] { "AnimeID" });
            DropTable("dbo.Genres");
            DropTable("dbo.Animes");
        }
    }
}
