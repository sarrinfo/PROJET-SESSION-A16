namespace WebApiProjetSessionA_16.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Annonces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photos = c.String(),
                        Titre = c.String(nullable: false),
                        NombrePieces = c.Int(),
                        NombreSDB = c.Int(),
                        Surface = c.Int(),
                        Inclusion = c.String(),
                        Exclusion = c.String(),
                        AutresDescription = c.String(),
                        BIENID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BienImmobiliers", t => t.BIENID, cascadeDelete: true)
                .Index(t => t.BIENID);
            
            CreateTable(
                "dbo.BienImmobiliers",
                c => new
                    {
                        BienID = c.Int(nullable: false, identity: true),
                        ImmeubleID = c.String(nullable: false, maxLength: 128),
                        Type_BIENIMMOBILIER = c.String(),
                        Prix_loyer = c.Double(),
                    })
                .PrimaryKey(t => t.BienID)
                .ForeignKey("dbo.Immeubles", t => t.ImmeubleID, cascadeDelete: true)
                .Index(t => t.ImmeubleID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BIENID = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BienImmobiliers", t => t.BIENID, cascadeDelete: true)
                .Index(t => t.BIENID);
            
            CreateTable(
                "dbo.Immeubles",
                c => new
                    {
                        ImmeubleID = c.String(nullable: false, maxLength: 128),
                        Photos = c.String(),
                        AnneeConstruction = c.DateTime(nullable: false),
                        AdresseId = c.Int(nullable: false),
                        Type_Immeuble = c.String(),
                    })
                .PrimaryKey(t => t.ImmeubleID)
                .ForeignKey("dbo.Adresses", t => t.AdresseId, cascadeDelete: true)
                .Index(t => t.AdresseId);
            
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codePostal = c.String(nullable: false),
                        numero = c.Int(nullable: false),
                        rue = c.String(),
                        localite = c.String(),
                        ville = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BienImmobiliers", "ImmeubleID", "dbo.Immeubles");
            DropForeignKey("dbo.Immeubles", "AdresseId", "dbo.Adresses");
            DropForeignKey("dbo.Images", "BIENID", "dbo.BienImmobiliers");
            DropForeignKey("dbo.Annonces", "BIENID", "dbo.BienImmobiliers");
            DropIndex("dbo.Immeubles", new[] { "AdresseId" });
            DropIndex("dbo.Images", new[] { "BIENID" });
            DropIndex("dbo.BienImmobiliers", new[] { "ImmeubleID" });
            DropIndex("dbo.Annonces", new[] { "BIENID" });
            DropTable("dbo.Adresses");
            DropTable("dbo.Immeubles");
            DropTable("dbo.Images");
            DropTable("dbo.BienImmobiliers");
            DropTable("dbo.Annonces");
        }
    }
}
