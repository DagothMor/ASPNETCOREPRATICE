using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.Models.Response.CustomerFolder
{
	/// <summary>
	/// Responds to request for a customer
	/// </summary>
	public class CustomerResponse
	{
		/// <summary>
		/// Customer's identification.
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Customer's first name.
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// Customer's money.
		/// </summary>
		public float Money { get; set; }
		/// <summary>
		/// Customer's City
		/// </summary>
		public string City { get; set; }
	}
}
