namespace EFSampleEvaluation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMaxLength : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evaluations",
                c => new
                    {
                        ID = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evaluations");
        }
    }
}
