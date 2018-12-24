namespace WebApiProjetSessionA_16.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visites", "BIENIMMOBILIER_BienID", "dbo.BienImmobiliers");
            DropIndex("dbo.Visites", new[] { "BIENIMMOBILIER_BienID" });
            RenameColumn(table: "dbo.Visites", name: "BIENIMMOBILIER_BienID", newName: "BienImmobilierBienId");
            AlterColumn("dbo.Visites", "BienImmobilierBienId", c => c.Int(nullable: false));
            CreateIndex("dbo.Visites", "BienImmobilierBienId");
            AddForeignKey("dbo.Visites", "BienImmobilierBienId", "dbo.BienImmobiliers", "BienID", cascadeDelete: true);
            DropColumn("dbo.Visites", "BienIDId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Visites", "BienIDId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Visites", "BienImmobilierBienId", "dbo.BienImmobiliers");
            DropIndex("dbo.Visites", new[] { "BienImmobilierBienId" });
            AlterColumn("dbo.Visites", "BienImmobilierBienId", c => c.Int());
            RenameColumn(table: "dbo.Visites", name: "IdBien", newName: "BIENIMMOBILIER_BienID");
            CreateIndex("dbo.Visites", "BIENIMMOBILIER_BienID");
            AddForeignKey("dbo.Visites", "BIENIMMOBILIER_BienID", "dbo.BienImmobiliers", "BienID");
        }
    }
}
