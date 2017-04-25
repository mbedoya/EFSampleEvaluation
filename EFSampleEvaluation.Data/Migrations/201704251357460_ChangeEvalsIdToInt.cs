namespace EFSampleEvaluation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEvalsIdToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Evaluations", "ID", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Evaluations", "ID", c => c.Short(nullable: false, identity: true));
        }
    }
}
