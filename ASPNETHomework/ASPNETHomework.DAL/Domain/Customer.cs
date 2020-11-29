using System;
using System.Collections.Generic;
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
		public string FirstName { get; set; }
		/// <summary>
		/// Customer's last name.
		/// </summary>
		public string LastName { get; set; }
	}
}
