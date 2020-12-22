using System.ComponentModel.DataAnnotations;

namespace ASPNETHomework.DAL.Domain
{
	public class Provider : BaseEntity
	{
		/// <summary>
		/// Name.
		/// </summary>
		[StringLength(250)]
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// Phone.
		/// </summary>
		[StringLength(25)]
		[Required]
		public string Phone { get; set; }
		/// <summary>
		/// City.
		/// </summary>
		[StringLength(25)]
		public string City { get; set; }
	}

}
