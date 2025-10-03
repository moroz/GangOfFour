namespace GangOfFour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Events",
                c => new
                    {
                        EventId = c.Guid(nullable: false),
                        TitleEn = c.String(nullable: false, maxLength: 100),
                        DescriptionEn = c.String(nullable: false, maxLength: 2000),
                        StartsAt = c.DateTime(nullable: false),
                        EndsAt = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Events");
        }
    }
}
