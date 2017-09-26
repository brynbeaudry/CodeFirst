using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Models
{
	public class Player
	{
		public int PlayerId { get; set; }
		public int JerseyNumber { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Position { get; set; }
		public string Country { get; set; }

		public int TeamId { get; set; }
		public Team Team { get; set; }
	}
}