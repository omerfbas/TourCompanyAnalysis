namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _954 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RehberDil", "DilId", "dbo.Dil");
            DropForeignKey("dbo.RehberDil", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.Turlar", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.Turlar", "DilId", "dbo.Dil");
            DropForeignKey("dbo.RehberYer", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.RehberYer", "YerId", "dbo.Yer");
            DropForeignKey("dbo.TurBileti", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.TurBileti", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.Turistler", "BolgeId", "dbo.Bolge");
            DropForeignKey("dbo.Turistler", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti");
            DropForeignKey("dbo.TurYer", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.TurYer", "YerId", "dbo.Yer");
            AddColumn("dbo.Fatura", "Tutar", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddForeignKey("dbo.RehberDil", "DilId", "dbo.Dil", "DilId");
            AddForeignKey("dbo.RehberDil", "RehberId", "dbo.Rehberler", "Id");
            AddForeignKey("dbo.Turlar", "RehberId", "dbo.Rehberler", "Id");
            AddForeignKey("dbo.Turlar", "DilId", "dbo.Dil", "DilId");
            AddForeignKey("dbo.RehberYer", "RehberId", "dbo.Rehberler", "Id");
            AddForeignKey("dbo.RehberYer", "YerId", "dbo.Yer", "YerId");
            AddForeignKey("dbo.TurBileti", "FaturaId", "dbo.Fatura", "FaturaId");
            AddForeignKey("dbo.TurBileti", "TurId", "dbo.Turlar", "TurId");
            AddForeignKey("dbo.Turistler", "BolgeId", "dbo.Bolge", "BolgeId");
            AddForeignKey("dbo.Turistler", "FaturaId", "dbo.Fatura", "FaturaId");
            AddForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti", "Id");
            AddForeignKey("dbo.TurYer", "TurId", "dbo.Turlar", "TurId");
            AddForeignKey("dbo.TurYer", "YerId", "dbo.Yer", "YerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TurYer", "YerId", "dbo.Yer");
            DropForeignKey("dbo.TurYer", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti");
            DropForeignKey("dbo.Turistler", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.Turistler", "BolgeId", "dbo.Bolge");
            DropForeignKey("dbo.TurBileti", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.TurBileti", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.RehberYer", "YerId", "dbo.Yer");
            DropForeignKey("dbo.RehberYer", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.Turlar", "DilId", "dbo.Dil");
            DropForeignKey("dbo.Turlar", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.RehberDil", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.RehberDil", "DilId", "dbo.Dil");
            DropColumn("dbo.Fatura", "Tutar");
            AddForeignKey("dbo.TurYer", "YerId", "dbo.Yer", "YerId", cascadeDelete: true);
            AddForeignKey("dbo.TurYer", "TurId", "dbo.Turlar", "TurId", cascadeDelete: true);
            AddForeignKey("dbo.Turistler", "TurBiletiId", "dbo.TurBileti", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Turistler", "FaturaId", "dbo.Fatura", "FaturaId", cascadeDelete: true);
            AddForeignKey("dbo.Turistler", "BolgeId", "dbo.Bolge", "BolgeId", cascadeDelete: true);
            AddForeignKey("dbo.TurBileti", "TurId", "dbo.Turlar", "TurId", cascadeDelete: true);
            AddForeignKey("dbo.TurBileti", "FaturaId", "dbo.Fatura", "FaturaId", cascadeDelete: true);
            AddForeignKey("dbo.RehberYer", "YerId", "dbo.Yer", "YerId", cascadeDelete: true);
            AddForeignKey("dbo.RehberYer", "RehberId", "dbo.Rehberler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Turlar", "DilId", "dbo.Dil", "DilId", cascadeDelete: true);
            AddForeignKey("dbo.Turlar", "RehberId", "dbo.Rehberler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RehberDil", "RehberId", "dbo.Rehberler", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RehberDil", "DilId", "dbo.Dil", "DilId", cascadeDelete: true);
        }
    }
}
