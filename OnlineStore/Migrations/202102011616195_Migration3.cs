namespace OnlineStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Cart_ID = c.Int(nullable: false),
                        Cart_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Carts", t => t.Cart_ID1)
                .Index(t => t.Cart_ID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Cart_ID1", "dbo.Carts");
            DropIndex("dbo.Items", new[] { "Cart_ID1" });
            DropTable("dbo.Items");
            DropTable("dbo.Carts");
        }
    }
}
