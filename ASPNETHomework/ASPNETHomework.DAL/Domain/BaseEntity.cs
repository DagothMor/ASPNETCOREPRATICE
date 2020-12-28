using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
		public int Id { get; set; }
	}
}
