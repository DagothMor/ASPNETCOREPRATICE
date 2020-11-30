using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Order.
	/// </summary>
	public class Order : BaseEntity
	{
		/// <summary>
		/// Customer.
		/// </summary>
		public Customer Customer { get; set; }
		/// <summary>
		/// Date of order.
		/// </summary>
		[Required]
		public DateTime Date { get; set; }
		/// <summary>
		/// Time of order.
		/// </summary>
		[Required]
		public DateTime Time { get; set; }
		/// <summary>
		/// Products
		/// </summary>
		public List<Product> Products { get; set; }
	}
}
