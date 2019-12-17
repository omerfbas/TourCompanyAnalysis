namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolge",
                c => new
                    {
                        BolgeId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        UlasimGideri = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BolgeId);
            
            CreateTable(
                "dbo.Dil",
                c => new
                    {
                        DilId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Rehberler_Id = c.Int(),
                        Turistler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DilId)
                .ForeignKey("dbo.Rehberler", t => t.Rehberler_Id)
                .ForeignKey("dbo.Turistler", t => t.Turistler_Id)
                .Index(t => t.Rehberler_Id)
                .Index(t => t.Turistler_Id);
            
            CreateTable(
                "dbo.Fatura",
                c => new
                    {
                        FaturaId = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Adres = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        FaturaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaId);
            
            CreateTable(
                "dbo.RehberDil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RehberId = c.Int(nullable: false),
                        DilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dil", t => t.DilId, cascadeDelete: true)
                .ForeignKey("dbo.Rehberler", t => t.RehberId, cascadeDelete: true)
                .Index(t => t.RehberId)
                .Index(t => t.DilId);
            
            CreateTable(
                "dbo.Rehberler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Cinsiyet = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        Uyruk = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turlar",
                c => new
                    {
                        TurId = c.Int(nullable: false, identity: true),
                        RehberId = c.Int(nullable: false),
                        DilId = c.Int(nullable: false),
                        Ad = c.String(),
                        Aciklama = c.String(),
                        Kapasite = c.Int(nullable: false),
                        Tarihi = c.DateTime(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TurId)
                .ForeignKey("dbo.Dil", t => t.DilId, cascadeDelete: true)
                .ForeignKey("dbo.Rehberler", t => t.RehberId, cascadeDelete: true)
                .Index(t => t.RehberId)
                .Index(t => t.DilId);
            
            CreateTable(
                "dbo.RehberYer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RehberId = c.Int(nullable: false),
                        YerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rehberler", t => t.RehberId, cascadeDelete: true)
                .ForeignKey("dbo.Yer", t => t.YerId, cascadeDelete: true)
                .Index(t => t.RehberId)
                .Index(t => t.YerId);
            
            CreateTable(
                "dbo.Yer",
                c => new
                    {
                        YerId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Aciklama = c.String(),
                        Ucret = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.YerId);
            
            CreateTable(
                "dbo.TurBileti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TurId = c.Int(nullable: false),
                        FaturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fatura", t => t.FaturaId, cascadeDelete: true)
                .ForeignKey("dbo.Turlar", t => t.TurId, cascadeDelete: true)
                .Index(t => t.TurId)
                .Index(t => t.FaturaId);
            
            CreateTable(
                "dbo.Turistler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BolgeId = c.Int(nullable: false),
                        FaturaId = c.Int(nullable: false),
                        AdSoyad = c.String(),
                        Cinsiyet = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        Uyruk = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        TurBileti_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bolge", t => t.BolgeId, cascadeDelete: true)
                .ForeignKey("dbo.Fatura", t => t.FaturaId, cascadeDelete: true)
                .ForeignKey("dbo.TurBileti", t => t.TurBileti_Id)
                .Index(t => t.BolgeId)
                .Index(t => t.FaturaId)
                .Index(t => t.TurBileti_Id);
            
            CreateTable(
                "dbo.TurYer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TurId = c.Int(nullable: false),
                        YerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turlar", t => t.TurId, cascadeDelete: true)
                .ForeignKey("dbo.Yer", t => t.YerId, cascadeDelete: true)
                .Index(t => t.TurId)
                .Index(t => t.YerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TurYer", "YerId", "dbo.Yer");
            DropForeignKey("dbo.TurYer", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.TurBileti", "TurId", "dbo.Turlar");
            DropForeignKey("dbo.Turistler", "TurBileti_Id", "dbo.TurBileti");
            DropForeignKey("dbo.Turistler", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.Dil", "Turistler_Id", "dbo.Turistler");
            DropForeignKey("dbo.Turistler", "BolgeId", "dbo.Bolge");
            DropForeignKey("dbo.TurBileti", "FaturaId", "dbo.Fatura");
            DropForeignKey("dbo.RehberYer", "YerId", "dbo.Yer");
            DropForeignKey("dbo.RehberYer", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.RehberDil", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.Turlar", "RehberId", "dbo.Rehberler");
            DropForeignKey("dbo.Turlar", "DilId", "dbo.Dil");
            DropForeignKey("dbo.Dil", "Rehberler_Id", "dbo.Rehberler");
            DropForeignKey("dbo.RehberDil", "DilId", "dbo.Dil");
            DropIndex("dbo.TurYer", new[] { "YerId" });
            DropIndex("dbo.TurYer", new[] { "TurId" });
            DropIndex("dbo.Turistler", new[] { "TurBileti_Id" });
            DropIndex("dbo.Turistler", new[] { "FaturaId" });
            DropIndex("dbo.Turistler", new[] { "BolgeId" });
            DropIndex("dbo.TurBileti", new[] { "FaturaId" });
            DropIndex("dbo.TurBileti", new[] { "TurId" });
            DropIndex("dbo.RehberYer", new[] { "YerId" });
            DropIndex("dbo.RehberYer", new[] { "RehberId" });
            DropIndex("dbo.Turlar", new[] { "DilId" });
            DropIndex("dbo.Turlar", new[] { "RehberId" });
            DropIndex("dbo.RehberDil", new[] { "DilId" });
            DropIndex("dbo.RehberDil", new[] { "RehberId" });
            DropIndex("dbo.Dil", new[] { "Turistler_Id" });
            DropIndex("dbo.Dil", new[] { "Rehberler_Id" });
            DropTable("dbo.TurYer");
            DropTable("dbo.Turistler");
            DropTable("dbo.TurBileti");
            DropTable("dbo.Yer");
            DropTable("dbo.RehberYer");
            DropTable("dbo.Turlar");
            DropTable("dbo.Rehberler");
            DropTable("dbo.RehberDil");
            DropTable("dbo.Fatura");
            DropTable("dbo.Dil");
            DropTable("dbo.Bolge");
        }
    }
}
