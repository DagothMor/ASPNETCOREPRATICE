using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// Order Dto.
	/// </summary>
	public class OrderDto : BaseDto
	{
		/// <summary>
		/// Customer.
		/// </summary>
		public Customer Customer { get; set; }
		/// <summary>
		/// Date of order.
		/// </summary>
		public DateTime DateTimeOffset { get; set; }
		/// <summary>
		/// Array of products
		/// </summary>
		public List<Product> Products { get; set; }
	}
}
