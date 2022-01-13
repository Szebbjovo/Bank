namespace Bank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sziauramhello : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "employe", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "employe");
        }
    }
}
