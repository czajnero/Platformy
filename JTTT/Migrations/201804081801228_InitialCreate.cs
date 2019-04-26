namespace JTTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JTTTActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JTTTRecordActions", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.JTTTRecordActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        SearchText = c.String(),
                        EmailTo = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JTTTActions", "Recipe_Id", "dbo.JTTTRecordActions");
            DropIndex("dbo.JTTTActions", new[] { "Recipe_Id" });
            DropTable("dbo.JTTTRecordActions");
            DropTable("dbo.JTTTActions");
        }
    }
}
