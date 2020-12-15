using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.Models.Requests.ProductFolder
{
	public class UpdateProductRequest : CreateProductRequest
	{
		/// <summary>
		/// Entity identification.
		/// </summary>
		[Required]
		public int Id { get; set; }
	}
}
