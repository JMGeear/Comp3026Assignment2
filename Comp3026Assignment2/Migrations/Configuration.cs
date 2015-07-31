namespace Comp3026Assignment2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Comp3026Assignment2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Comp3026Assignment2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Comp3026Assignment2.Models.ApplicationDbContext";
        }

        protected override void Seed(Comp3026Assignment2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                p => p.Email,
                new ApplicationUser
                {
                    UserName = MvcApplication.OWNER,
                    PasswordHash = "AJlXAxvb4e7rytqD+VHlFaMUUZb5NgMC5ENhB0dzrix2gnFEmBDpQLCi0mFZbh3rig==",
                    SecurityStamp = "5b2913d4-7d1d-4a3a-b8d5-769c732d68ea",
                    Email = MvcApplication.OWNER
                }
            );
        }
    }
}
