using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Provider.
	/// </summary>
	public class Provider : BaseEntity
	{
		/// <summary>
		/// Name.
		/// </summary>
		[StringLength(250)]
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// Phone.
		/// </summary>
		[StringLength(25)]
		[Required]
		public string Phone { get; set; }
	}
}
