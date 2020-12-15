using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.Response.ProductFolder
{
	public class ProductResponse
	{
		/// <summary>
		/// Category of product.
		/// </summary>
		public Category Category { get; set; }

		/// <summary>
		/// Name of product.
		/// </summary>
		[StringLength(25)]
		public string Name { get; set; }

		/// <summary>
		/// Description.
		/// </summary>
		[StringLength(3000)]
		public string Description { get; set; }

		/// <summary>
		/// Price.
		/// </summary>
		[Required]
		public double Price { get; set; }

		/// <summary>
		/// Provider.
		/// </summary>
		public Provider Provider { get; set; }

		/// <summary>
		/// Provider's identification.
		/// </summary>
		public long ProviderId { get; set; }

		/// <summary>
		/// Many to many with order.
		/// </summary>
		public virtual List<Order> Orders { get; set; }

		/// <summary>
		/// Availabilities current product in stores.
		/// </summary>
		public ICollection<Availability> Availabilities { get; set; }
		/// <summary>
		/// Provider name.
		/// </summary>
		public string ProviderName { get; set; }

		/// <summary>
		/// Provider phone.
		/// </summary>
		public string ProviderPhone { get; set; }
	}
}
