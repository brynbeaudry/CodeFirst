using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
	public class Team
	{
		public int TeamId { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public List<Player> Players { get; set; }
	}
}