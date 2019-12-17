namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class odemeTipi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fatura", "OdemeTipi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fatura", "OdemeTipi");
        }
    }
}
