using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.Models.Requests.Order
{
	/// <summary>
	/// Request for update an order
	/// </summary>
	public class UpdateTestRequest:CreateTestRequest
	{
		/// <summary>
		/// Entity identification.
		/// </summary>
		[Required]
		public int Id { get; set; }
	}
}
