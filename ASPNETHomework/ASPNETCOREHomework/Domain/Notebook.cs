using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETCOREHomework.Database.Domain
{
	public class Notebook
	{
		public Guid id { get; set; }
		public string ArtCode { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Model { get; set; }
		public double Weight { get; set; }
		public DateTime Warranty { get; set; }
		public string Address { get; set; }

	}
}
