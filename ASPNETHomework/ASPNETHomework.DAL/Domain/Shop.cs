using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Shops.
	/// </summary>
	public class Shop : BaseEntity
	{
		/// <summary>
		/// Shop name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Shop number.
		/// </summary>
		[StringLength(25)]
		[Required]
		public string Phone { get; set; }

		/// <summary>
		/// Availability of the current products in shops.
		/// </summary>
		public ICollection<Availability> Availabilities { get; set; }
	}
}
