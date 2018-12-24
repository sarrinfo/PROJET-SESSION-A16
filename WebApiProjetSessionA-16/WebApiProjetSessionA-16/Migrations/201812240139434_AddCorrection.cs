namespace WebApiProjetSessionA_16.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCorrection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visites", "VisiteurId", "dbo.Visiteurs");
            DropIndex("dbo.Visites", new[] { "VisiteurId" });
            AlterColumn("dbo.Visites", "VisiteurId", c => c.Int());
            CreateIndex("dbo.Visites", "VisiteurId");
            AddForeignKey("dbo.Visites", "VisiteurId", "dbo.Visiteurs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visites", "VisiteurId", "dbo.Visiteurs");
            DropIndex("dbo.Visites", new[] { "VisiteurId" });
            AlterColumn("dbo.Visites", "VisiteurId", c => c.Int(nullable: false));
            CreateIndex("dbo.Visites", "VisiteurId");
            AddForeignKey("dbo.Visites", "VisiteurId", "dbo.Visiteurs", "Id", cascadeDelete: true);
        }
    }
}
