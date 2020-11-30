using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// Customer Dto.
	/// </summary>
	class CustomerDto : BaseDto
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
