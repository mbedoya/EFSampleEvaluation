namespace EFSampleEvaluation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EvalNameChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.evaluation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Evaluations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Evaluations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.evaluation");
        }
    }
}
