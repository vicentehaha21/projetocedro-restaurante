namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pratos",
                c => new
                    {
                        PratoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Single(nullable: false),
                        restauranteID = c.Int(),
                    })
                .PrimaryKey(t => t.PratoID)
                .ForeignKey("dbo.Restaurante", t => t.restauranteID)
                .Index(t => t.restauranteID);
            
            CreateTable(
                "dbo.Restaurante",
                c => new
                    {
                        restauranteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.restauranteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pratos", "restauranteID", "dbo.Restaurante");
            DropIndex("dbo.Pratos", new[] { "restauranteID" });
            DropTable("dbo.Restaurante");
            DropTable("dbo.Pratos");
        }
    }
}
