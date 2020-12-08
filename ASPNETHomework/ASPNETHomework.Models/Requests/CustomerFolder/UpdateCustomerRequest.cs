using System.ComponentModel.DataAnnotations;

namespace ASPNETHomework.Models.Requests.CustomerFolder
{
	/// <summary>
	/// Request for update a customer.
	/// </summary>
	public class UpdateCustomerRequest : CreateCustomerRequest
	{
		/// <summary>
		/// Entity identification.
		/// </summary>
		[Required]
		public int Id { get; set; }
	}
}
