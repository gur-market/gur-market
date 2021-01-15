namespace gür_market.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<gür_market.Context.GurMarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           // AutomaticMigrationDataLossAllowed = true;
            ContextKey = "gür_market.Context.GurMarContext";
        }

        protected override void Seed(gür_market.Context.GurMarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
