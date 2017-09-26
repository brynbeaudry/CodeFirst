namespace EntityCodeFirst.Migrations.Hockey
{
	using EntityCodeFirst.Data;
	using EntityCodeFirst.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityCodeFirst.Data.HockeyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Hockey";
        }

		protected override void Seed(EntityCodeFirst.Data.HockeyContext context)
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

			context.Teams.AddOrUpdate(t => t.Name,
				getTeams().ToArray()
			);
			context.SaveChanges();

			context.Players.AddOrUpdate(p => new { p.FirstName, p.LastName },
				getPlayers(context).ToArray()
			);
			context.SaveChanges();
		}

		private List<Player> getPlayers(HockeyContext context)
		{
			List<Player> players = new List<Player>()
			{
				new Player()
				{
					JerseyNumber=70,
					FirstName="Bob",
					LastName="Smith",
					Position="Goalie",
					Country="Canada",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId
				},
				new Player()
				{
					JerseyNumber=45,
					FirstName="Tom",
					LastName="Jones",
					Position="Right Wing",
					Country="Sweeden",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId
				},
				new Player()
				{
					JerseyNumber=23,
					FirstName="Bill",
					LastName="Stevens",
					Position="Center",
					Country="Finland",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Canucks").TeamId
				},
				new Player()
				{
					JerseyNumber=33,
					FirstName="Joe",
					LastName="Barker",
					Position="Goalie",
					Country="USA",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
				},
				new Player()
				{
					JerseyNumber=103,
					FirstName="Tim",
					LastName="Stewart",
					Position="Defense",
					Country="Switzerland",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
				},
				new Player()
				{
					JerseyNumber=73,
					FirstName="Jason",
					LastName="Gregory",
					Position="Left Wing",
					Country="France",
					TeamId = context.Teams.FirstOrDefault(t => t.Name == "Oilers").TeamId
				},
			};

			return players;
		}

		private List<Team> getTeams()
		{
			List<Team> teams = new List<Team>()
			{
				new Team() {Name="Canucks", City="Vancouver"},
				new Team() {Name="Oilers", City="Edmonton"},
				new Team() {Name="Flames", City="Calgary"},
			};

			return teams;
		}
    }
}
