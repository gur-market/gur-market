namespace gür_market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kasas",
                c => new
                    {
                        KasaID = c.Int(nullable: false, identity: true),
                        ToplamBorc = c.Int(nullable: false),
                        ToplamAlacakMiktari = c.Int(nullable: false),
                        PotansiyelKarZarar = c.Int(nullable: false),
                        MevcutKasaMiktari = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KasaID);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAdSoyad = c.String(),
                        MusteriTc = c.String(),
                        MusteriTel = c.Int(nullable: false),
                        TarihSaat = c.String(),
                        BorcMiktari = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.PesinSatis",
                c => new
                    {
                        SatisId = c.Int(nullable: false, identity: true),
                        BarkodNo = c.Int(nullable: false),
                        UrunAdi = c.String(),
                        BirimAdet = c.Int(nullable: false),
                        Fiyat = c.Int(nullable: false),
                        Toplam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SatisId);
            
            CreateTable(
                "dbo.Stoks",
                c => new
                    {
                        StokID =  c.Int(nullable: false, identity: true),
                        IrsaliyeNo = c.Int(nullable: false),
                        TedarikciAdi = c.String(),
                        BarkodNo = c.Int(nullable: false),
                        UrunAdi = c.String(),
                        BirimAdedi = c.Int(nullable: false),
                        BirimFiyat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StokID);
           
            CreateTable(
                "dbo.Tedarikcis",
                c => new
                    {
                        TedarikciId = c.Int(nullable: false, identity: true),
                        TedarikciAdi = c.String(),
                        TarihSaat = c.String(),
                        ToplamBorc = c.Int(nullable: false),
                        OdenenBorc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TedarikciId);
            
            CreateTable(
                "dbo.VeresiyeSatis",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAdSoyad = c.String(),
                        MusteriTel = c.Int(nullable: false),
                        TarihSaat = c.String(),
                        BarkodNo = c.Int(nullable: false),
                        UrunAdi = c.String(),
                        BirimAdet = c.Int(nullable: false),
                        Fiyat = c.Int(nullable: false),
                        Toplam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MusteriId);

            CreateTable(
                 "dbo.UrunAls",
                 c => new
                 {
                     UrunAlisID = c.Int(nullable: false, identity: true),
                     IrsaliyeNo = c.Int(nullable: false),
                     TedarikciAdi = c.String(),
                     BarkodNo = c.Int(nullable: false),
                     UrunAdi = c.String(),
                     BirimAdedi = c.Int(nullable: false),
                     BirimFiyat = c.Int(nullable: false),
                 })
                 .PrimaryKey(t => t.UrunAlisID);

        }
        
        public override void Down()
        {
            DropTable("dbo.VeresiyeSatis");
            DropTable("dbo.Tedarikcis");
            DropTable("dbo.Stoks");
            DropTable("dbo.PesinSatis");
            DropTable("dbo.Musteris");
            DropTable("dbo.Kasas");
            DropTable("dbo.UrunAls");
        }
    }
}
