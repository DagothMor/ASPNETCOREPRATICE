using System;
using System.Collections.Generic;
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
		public DateTime Date { get; set; }
		/// <summary>
		/// Time of order.
		/// </summary>
		public DateTime Time { get; set; }
	}
}
