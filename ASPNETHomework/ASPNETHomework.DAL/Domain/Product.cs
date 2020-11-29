using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Product in the store.
	/// </summary>
	public class Product : BaseEntity
	{
		/// <summary>
		/// Category of product.
		/// </summary>
		public Category Category { get; set; }
		/// <summary>
		/// Name of product.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Description.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Price.
		/// </summary>
		public double Price { get; set; }
	}
}
