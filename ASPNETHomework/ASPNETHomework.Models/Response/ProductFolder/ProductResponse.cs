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
