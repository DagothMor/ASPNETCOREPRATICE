using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.Requests.Order
{
	/// <summary>
	/// Request for create an order
	/// </summary>
	public class CreateTestRequest
	{
		/// <summary>
		/// Customer.
		/// </summary>
		[Required]
		public Customer Customer { get; set; }
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
