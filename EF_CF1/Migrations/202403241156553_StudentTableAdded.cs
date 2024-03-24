    namespace EF_CF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EFStudent",
                c => new
                    {
                        RollNumber = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 50, unicode: false),
                        City = c.String(maxLength: 100),
                        Email = c.String(nullable: false),
                        TrainerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .Index(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EFStudent", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.EFStudent", new[] { "TrainerId" });
            DropTable("dbo.EFStudent");
        }
    }
}
