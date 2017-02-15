namespace Gap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        price = c.Double(nullable: false),
                        totalInShelf = c.Int(nullable: false),
                        totalInVault = c.Int(nullable: false),
                        storeId = c.Int(nullable: false),
                        storeName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Store", t => t.storeId, cascadeDelete: true)
                .Index(t => t.storeId);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "storeId", "dbo.Store");
            DropIndex("dbo.Article", new[] { "storeId" });
            DropTable("dbo.Store");
            DropTable("dbo.Article");
        }
    }
}
