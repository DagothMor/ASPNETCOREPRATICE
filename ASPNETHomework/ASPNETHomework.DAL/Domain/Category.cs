using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Category
	/// </summary>
	public class Category : BaseEntity
	{
		/// <summary>
		/// Type.
		/// </summary>
		[Required]
		public string Type { get; set; }
	}
}
