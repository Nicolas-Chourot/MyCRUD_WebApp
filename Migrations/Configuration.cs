namespace MyCRUD_WebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyCRUD_WebApp.Data.MyCRUD_WebAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // Dangeureux mais nécessaire en début de conception des tables
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyCRUD_WebApp.Data.MyCRUD_WebAppContext context)
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
        }
    }
}
