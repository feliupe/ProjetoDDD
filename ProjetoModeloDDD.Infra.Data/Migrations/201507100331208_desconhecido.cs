namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class desconhecido : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Sobrenome = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        DataCadastro = c.DateTime(nullable: false, precision: 0),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
