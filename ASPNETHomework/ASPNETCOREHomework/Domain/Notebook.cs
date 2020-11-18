using System;

namespace ASPNETCOREHomework.Database.Domain
{
	/// <summary>
	/// Notebook
	/// </summary>
	public class Notebook
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public Guid id { get; set; }
		/// <summary>
		/// Articular Code
		/// </summary>
		public string ArtCode { get; set; }
		/// <summary>
		/// Description
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Price
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// Model number
		/// </summary>
		public string Model { get; set; }
		/// <summary>
		/// Weight in kilogram
		/// </summary>
		public double Weight { get; set; }
		/// <summary>
		/// Warranty
		/// </summary>
		public DateTime Warranty { get; set; }
		/// <summary>
		/// Address
		/// </summary>
		public string Address { get; set; }

	}
}
