namespace exam_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassRoom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Exams", "ClassRoomtId", c => c.Int(nullable: false));
            AddColumn("dbo.Exams", "ClassRoom_Id", c => c.Int());
            CreateIndex("dbo.Exams", "ClassRoom_Id");
            AddForeignKey("dbo.Exams", "ClassRoom_Id", "dbo.ClassRooms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "ClassRoom_Id", "dbo.ClassRooms");
            DropIndex("dbo.Exams", new[] { "ClassRoom_Id" });
            DropColumn("dbo.Exams", "ClassRoom_Id");
            DropColumn("dbo.Exams", "ClassRoomtId");
            DropTable("dbo.ClassRooms");
        }
    }
}
