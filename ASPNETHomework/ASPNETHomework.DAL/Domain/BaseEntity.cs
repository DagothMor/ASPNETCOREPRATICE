using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Based class for domain models.
	/// </summary>
	public abstract class BaseEntity
	{
		/// <summary>
		/// Identification.
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }
	}
}
