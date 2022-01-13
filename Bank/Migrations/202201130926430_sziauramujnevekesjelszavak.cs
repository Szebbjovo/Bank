namespace Bank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sziauramujnevekesjelszavak : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "username", c => c.String());
            AddColumn("dbo.Posts", "password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "password");
            DropColumn("dbo.Posts", "username");
        }
    }
}
