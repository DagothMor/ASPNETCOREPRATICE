using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.Models.Requests.OrderFolder
{
	/// <summary>
	/// Request for update an order
	/// </summary>
	public class UpdateOrderRequest : CreateOrderRequest
	{
		/// <summary>
		/// Entity identification.
		/// </summary>
		[Required]
		public int Id { get; set; }
	}
}
