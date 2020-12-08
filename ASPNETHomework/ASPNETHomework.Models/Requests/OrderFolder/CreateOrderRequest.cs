using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.Requests.Order
{
	/// <summary>
	/// Request for create an order
	/// </summary>
	public class CreateOrderRequest
	{
		/// <summary>
		/// Customer.
		/// </summary>
		[Required]
		public Customer Customers { get; set; }
		/// <summary>
		/// Date of order.
		/// </summary>
		[Required]
		public DateTime DateTimeOffset { get; set; }
		/// <summary>
		/// Array of products
		/// </summary>
		[Required]
		public List<Product> Products { get; set; }
	}
}
