namespace Bank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sziaUram : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        egyenleg = c.Double(nullable: false),
                        kNev = c.String(),
                        vNev = c.String(),
                        szuletes = c.DateTime(nullable: false),
                        regisztracioDatuma = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
