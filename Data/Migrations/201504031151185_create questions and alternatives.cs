namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createquestionsandalternatives : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alternatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 250, unicode: false),
                        IsCorrect = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SetpId = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 250, unicode: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Step_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .Index(t => t.Step_Id);
            
            AddColumn("dbo.Steps", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Steps", "UpdatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alternatives", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Step_Id", "dbo.Steps");
            DropIndex("dbo.Questions", new[] { "Step_Id" });
            DropIndex("dbo.Alternatives", new[] { "QuestionId" });
            DropColumn("dbo.Steps", "UpdatedAt");
            DropColumn("dbo.Steps", "CreatedAt");
            DropTable("dbo.Questions");
            DropTable("dbo.Alternatives");
        }
    }
}
