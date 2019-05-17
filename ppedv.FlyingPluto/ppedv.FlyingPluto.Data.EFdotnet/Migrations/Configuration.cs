namespace ppedv.FlyingPluto.Data.EFdotnet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ppedv.FlyingPluto.Data.EF.EfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ppedv.FlyingPluto.Data.EF.EfContext";
        }

        protected override void Seed(ppedv.FlyingPluto.Data.EF.EfContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
