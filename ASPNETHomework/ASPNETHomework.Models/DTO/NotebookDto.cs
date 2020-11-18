using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ASPNETCOREHomework.Database.Domain;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// DTO for <see cref="Notebook"/>
	/// </summary>
	public class NotebookDto
	{
		/// <summary>
		/// Articular Code
		/// </summary>
		[Required]
		public string ArtCode { get; set; }
		/// <summary>
		/// Description
		/// </summary>
		[MaxLength(2000)]
		public string Description { get; set; }
		/// <summary>
		/// Price
		/// </summary>
		[Required]
		public double Price { get; set; }
		/// <summary>
		/// Model
		/// </summary>
		[MaxLength(2000)]
		public string Model { get; set; }
		/// <summary>
		/// Weight
		/// </summary>
		[Required]
		public double Weight { get; set; }
		/// <summary>
		/// Warranty
		/// </summary>
		[Required]
		public DateTime Warranty { get; set; }
		/// <summary>
		/// Address
		/// </summary>
		[MaxLength(2000)]
		public string Address { get; set; }
	}
}
