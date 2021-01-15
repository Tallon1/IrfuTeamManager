namespace IrfuTeamManager.Migrations.IRFU
{
    using IrfuTeamManager.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IrfuTeamManager.Data.IrfuContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IRFU";
        }

        protected override void Seed(IrfuTeamManager.Data.IrfuContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data e.g.

            //       context.People.AddOrUpdate(
            //         p => p.FullName,
            //         new Person { FullName = "Karl Tallon" },
            //         new Person { FullName = "John Doe" },
            //         new Person { FullName = "Jane Doe" }
            //       );

            context.Teams.AddOrUpdate(
                t => t.TeamName, DummyData.getTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(
                p => new { p.FirstName, p.LastName }, DummyData.getPlayers(context).ToArray());
        }
    }
}
