namespace exam_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
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
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        FacultyId = c.Int(nullable: false),
                        ExamSubjectId = c.Int(nullable: false),
                        ClassRoomId = c.Int(nullable: false),
                        StarTime = c.DateTime(nullable: false, precision: 0),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        ExamDuration = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoomId, cascadeDelete: true)
                .ForeignKey("dbo.ExamSubjects", t => t.ExamSubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId)
                .Index(t => t.ExamSubjectId)
                .Index(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.ExamSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameFaculty = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.Exams", "ExamSubjectId", "dbo.ExamSubjects");
            DropForeignKey("dbo.Exams", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.Exams", new[] { "ClassRoomId" });
            DropIndex("dbo.Exams", new[] { "ExamSubjectId" });
            DropIndex("dbo.Exams", new[] { "FacultyId" });
            DropTable("dbo.Faculties");
            DropTable("dbo.ExamSubjects");
            DropTable("dbo.Exams");
            DropTable("dbo.ClassRooms");
        }
    }
}
