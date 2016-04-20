namespace GMTSongbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Song_SongID", "dbo.Songs");
            DropIndex("dbo.Reviews", new[] { "Song_SongID" });
            RenameColumn(table: "dbo.Reviews", name: "Song_SongID", newName: "SongID");
            AlterColumn("dbo.Reviews", "SongID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "SongID");
            AddForeignKey("dbo.Reviews", "SongID", "dbo.Songs", "SongID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "SongID", "dbo.Songs");
            DropIndex("dbo.Reviews", new[] { "SongID" });
            AlterColumn("dbo.Reviews", "SongID", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "SongID", newName: "Song_SongID");
            CreateIndex("dbo.Reviews", "Song_SongID");
            AddForeignKey("dbo.Reviews", "Song_SongID", "dbo.Songs", "SongID");
        }
    }
}
