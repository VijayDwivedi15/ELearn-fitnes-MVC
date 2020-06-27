namespace ELearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forCourseCategory : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.CourseCategories",
                c => new
                    {
                        CourseCategoryID = c.Long(nullable: false, identity: true),
                        CourseName = c.String(),
                        Description = c.String(),
                        Duration = c.String(),
                        Price = c.Single(nullable: false),
                        CourseImage = c.String(),
                        InstructorID = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseCategoryID);
            
           
        }
        
        public override void Down()
        {
           
            
            DropTable("dbo.CourseCategories");
            
        }
    }
}
