using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.Models.DTO
{
	public class NotebookDto
	{
		[Required]
		public string ArtCode { get; set; }
		[MaxLength(2000)]
		public string Description { get; set; }
		[Required]
		public double Price { get; set; }
		[MaxLength(2000)]
		public string Model { get; set; }
		[Required]
		public double Weight { get; set; }
		[Required]
		public DateTime Warranty { get; set; }
		[MaxLength(2000)]
		public string Address { get; set; }
	}
}
