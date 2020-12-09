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
		public int CustomerId { get; set; }
		[ForeignKey("Id")]
		public Customer Customer { get; set; }
		/// <summary>
		/// Date of order.
		/// </summary>
		[Required]
		public DateTime DateTimeOffset { get; set; }
		/// <summary>
		/// Products
		/// </summary>
		public ICollection<Product> Products { get; set; }// efc tutor say that's correct instead of list.
	}
}
