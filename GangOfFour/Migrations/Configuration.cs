using GangOfFour.Models;

namespace GangOfFour.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            context.Events.AddOrUpdate(
                new Event
                {
                    TitleEn = "Example Event 1",
                    DescriptionEn = "Example description",
                    StartsAt = new DateTime(2025, 10, 1, 9, 0, 0),
                    EndsAt = new DateTime(2025, 10, 1, 11, 0, 0),
                    EventId = new Guid("0199aac4-698b-772d-b79a-085a45267a66"),
                });
        }
    }
}