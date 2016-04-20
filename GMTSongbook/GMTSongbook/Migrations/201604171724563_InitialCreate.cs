namespace GMTSongbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        StageName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        ArtistID = c.Int(nullable: false),
                        Title = c.String(),
                        ComposedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SongID)
                .ForeignKey("dbo.Artists", t => t.ArtistID, cascadeDelete: true)
                .Index(t => t.ArtistID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        ReviewDate = c.DateTime(nullable: false),
                        Comment = c.String(),
                        ReviewdBy = c.String(),
                        Song_SongID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Songs", t => t.Song_SongID)
                .Index(t => t.Song_SongID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "ArtistID", "dbo.Artists");
            DropForeignKey("dbo.Reviews", "Song_SongID", "dbo.Songs");
            DropIndex("dbo.Reviews", new[] { "Song_SongID" });
            DropIndex("dbo.Songs", new[] { "ArtistID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Songs");
            DropTable("dbo.Artists");
        }
    }
}
