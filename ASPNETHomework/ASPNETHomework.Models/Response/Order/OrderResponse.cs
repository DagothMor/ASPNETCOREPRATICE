using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.Response.Order
{
	/// <summary>
	/// Responds to request for an order
	/// </summary>
	public class OrderResponse
	{
		/// <summary>
		/// Customer.
		/// </summary>
		public Customer Customer { get; set; }
		/// <summary>
		/// Date of order.
		/// </summary>
		public DateTime Date { get; set; }
		/// <summary>
		/// Time of order.
		/// </summary>
		public DateTime Time { get; set; }
		/// <summary>
		/// Array of products
		/// </summary>
		public List<Product> Products { get; set; }
	}
}
