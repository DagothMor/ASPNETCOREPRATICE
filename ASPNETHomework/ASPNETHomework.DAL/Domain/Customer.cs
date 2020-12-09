using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Customer.
	/// </summary>
	public class Customer : BaseEntity
	{
		/// <summary>
		/// Customer's first name.
		/// </summary>
		[StringLength(25)]
		public string FirstName { get; set; }
		/// <summary>
		/// Customer's last name.
		/// </summary>
		[StringLength(25)]
		public string LastName { get; set; }
		/// <summary>
		/// Customer's money
		/// </summary>
		public float Money { get; set; }
		/// <summary>
		/// Customer's address
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Customer's supply.
		/// </summary>
		public virtual List<Order> Orders { get; set; }//why virtual?
	}
}
