using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.Models.DTO
{
	public class UserDto : BaseDto
	{
		/// <summary>
		/// Login.
		/// </summary>
		public string Login { get; set; }

		/// <summary>
		/// Password.
		/// </summary>
		public string Password { get; set; }
	}
}
