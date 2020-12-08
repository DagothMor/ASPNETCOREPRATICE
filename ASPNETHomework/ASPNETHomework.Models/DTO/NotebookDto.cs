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
		public string ArtCode { get; set; }
		/// <summary>
		/// Description
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Price
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// Model
		/// </summary>
		public string Model { get; set; }
		/// <summary>
		/// Weight
		/// </summary>
		public double Weight { get; set; }
		/// <summary>
		/// Warranty
		/// </summary>
		public DateTime Warranty { get; set; }
		/// <summary>
		/// Address
		/// </summary>
		public string Address { get; set; }
	}
}
