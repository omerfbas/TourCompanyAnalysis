namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _955 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turlar", "MevcutKisiSayisi", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turlar", "MevcutKisiSayisi");
        }
    }
}
