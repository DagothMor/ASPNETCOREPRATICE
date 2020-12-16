using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// Provider.
	/// </summary>
	public class ProviderDto : BaseDto
	{
		/// <summary>
		/// Name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Phone.
		/// </summary>
		public string Phone { get; set; }
	}
}
