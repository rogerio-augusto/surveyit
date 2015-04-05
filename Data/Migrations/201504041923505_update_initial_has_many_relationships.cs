namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_initial_has_many_relationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alternatives", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.Steps", "HotsiteId", "dbo.Hotsites");
            DropIndex("dbo.Questions", new[] { "Step_Id" });
            AlterColumn("dbo.Questions", "Step_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "Step_Id");
            AddForeignKey("dbo.Alternatives", "QuestionId", "dbo.Questions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Questions", "Step_Id", "dbo.Steps", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Steps", "HotsiteId", "dbo.Hotsites", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Steps", "HotsiteId", "dbo.Hotsites");
            DropForeignKey("dbo.Questions", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.Alternatives", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Questions", new[] { "Step_Id" });
            AlterColumn("dbo.Questions", "Step_Id", c => c.Int());
            CreateIndex("dbo.Questions", "Step_Id");
            AddForeignKey("dbo.Steps", "HotsiteId", "dbo.Hotsites", "Id");
            AddForeignKey("dbo.Questions", "Step_Id", "dbo.Steps", "Id");
            AddForeignKey("dbo.Alternatives", "QuestionId", "dbo.Questions", "Id");
        }
    }
}
