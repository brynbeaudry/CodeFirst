using EntityCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Data
{
	public class HockeyContext : DbContext
	{
		public HockeyContext()
            : base("DefaultConnection")
        {
		}

		public DbSet<Team> Teams { get; set; }
		public DbSet<Player> Players { get; set; }
	}
}