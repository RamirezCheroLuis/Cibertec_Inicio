namespace WebDeveloperDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstchangeofdboclient : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName");
            /*AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Client", "Apellidos");*/
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName");
            /*AddColumn("dbo.Client", "Apellidos", c => c.String(nullable: false));
            DropColumn("dbo.Client", "LastName");*/
        }
    }
}
