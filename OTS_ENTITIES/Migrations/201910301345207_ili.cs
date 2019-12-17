namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ili : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Turistler", "TurBileti_Id", "dbo.TurBileti");
            DropIndex("dbo.Turistler", new[] { "TurBileti_Id" });
            RenameColumn(table: "dbo.Turistler", name: "TurBileti_Id", newName: "TurBiletiId");
            AlterColumn("dbo.Turistler", "TurBiletiId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turistler", "TurBiletiId");
            AddForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti", "Id");
        }
       
        public override void Down()
        {
            DropForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti");
            DropIndex("dbo.Turistler", new[] { "TurBiletiId" });
            AlterColumn("dbo.Turistler", "TurBiletiId", c => c.Int());
            RenameColumn(table: "dbo.Turistler", name: "TurBiletiId", newName: "TurBileti_Id");
            CreateIndex("dbo.Turistler", "TurBileti_Id");
            AddForeignKey("dbo.Turistler", "TurBileti_Id", "dbo.TurBileti", "Id");
        }
    }
}
