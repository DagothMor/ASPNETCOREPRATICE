using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Availability in shops.
	/// </summary>
	public class Availability : BaseEntityWithLinks<Product, Shop>
	{
		/// <summary>
		/// Count of availability products.
		/// </summary>
		public int Count { get; set; }
	}
}
