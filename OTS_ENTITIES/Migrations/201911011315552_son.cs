namespace OTS_ENTITIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Bolge", name: "Ad", newName: "BolgeAdi");
            RenameColumn(table: "dbo.Fatura", name: "AdSoyad", newName: "AdiSoyadi");
            RenameColumn(table: "dbo.Fatura", name: "Mail", newName: "EmailAdresi");
            RenameColumn(table: "dbo.Rehberler", name: "Telefon", newName: "TelefonNumarasi");
            RenameColumn(table: "dbo.Turlar", name: "Ad", newName: "TurAdi");
            RenameColumn(table: "dbo.Yer", name: "Ad", newName: "YerAdi");
            RenameColumn(table: "dbo.Turistler", name: "Telefon", newName: "TelefonNumarasi");
            AlterColumn("dbo.Bolge", "BolgeAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bolge", "UlasimGideri", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Dil", "Ad", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Fatura", "AdiSoyadi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Fatura", "Adres", c => c.String(maxLength: 100));
            AlterColumn("dbo.Fatura", "Telefon", c => c.String(maxLength: 14));
            AlterColumn("dbo.Fatura", "Tutar", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Rehberler", "AdSoyad", c => c.String(nullable: false));
            AlterColumn("dbo.Rehberler", "Cinsiyet", c => c.String(nullable: false));
            AlterColumn("dbo.Rehberler", "TelefonNumarasi", c => c.String(nullable: false));
            AlterColumn("dbo.Rehberler", "Uyruk", c => c.String(nullable: false));
            AlterColumn("dbo.Turlar", "TurAdi", c => c.String(nullable: false));
            AlterColumn("dbo.Turlar", "Fiyat", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Yer", "YerAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Yer", "Ucret", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Turistler", "AdSoyad", c => c.String(nullable: false));
            AlterColumn("dbo.Turistler", "Cinsiyet", c => c.String(nullable: false));
            AlterColumn("dbo.Turistler", "TelefonNumarasi", c => c.String(nullable: false));
            AlterColumn("dbo.Turistler", "Uyruk", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turistler", "Uyruk", c => c.String());
            AlterColumn("dbo.Turistler", "TelefonNumarasi", c => c.String());
            AlterColumn("dbo.Turistler", "Cinsiyet", c => c.String());
            AlterColumn("dbo.Turistler", "AdSoyad", c => c.String());
            AlterColumn("dbo.Yer", "Ucret", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Yer", "YerAdi", c => c.String());
            AlterColumn("dbo.Turlar", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Turlar", "TurAdi", c => c.String());
            AlterColumn("dbo.Rehberler", "Uyruk", c => c.String());
            AlterColumn("dbo.Rehberler", "TelefonNumarasi", c => c.String());
            AlterColumn("dbo.Rehberler", "Cinsiyet", c => c.String());
            AlterColumn("dbo.Rehberler", "AdSoyad", c => c.String());
            AlterColumn("dbo.Fatura", "Tutar", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Fatura", "Telefon", c => c.String());
            AlterColumn("dbo.Fatura", "Adres", c => c.String());
            AlterColumn("dbo.Fatura", "AdiSoyadi", c => c.String());
            AlterColumn("dbo.Dil", "Ad", c => c.String());
            AlterColumn("dbo.Bolge", "UlasimGideri", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bolge", "BolgeAdi", c => c.String());
            RenameColumn(table: "dbo.Turistler", name: "TelefonNumarasi", newName: "Telefon");
            RenameColumn(table: "dbo.Yer", name: "YerAdi", newName: "Ad");
            RenameColumn(table: "dbo.Turlar", name: "TurAdi", newName: "Ad");
            RenameColumn(table: "dbo.Rehberler", name: "TelefonNumarasi", newName: "Telefon");
            RenameColumn(table: "dbo.Fatura", name: "EmailAdresi", newName: "Mail");
            RenameColumn(table: "dbo.Fatura", name: "AdiSoyadi", newName: "AdSoyad");
            RenameColumn(table: "dbo.Bolge", name: "BolgeAdi", newName: "Ad");
        }
    }
}
