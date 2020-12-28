using System.ComponentModel.DataAnnotations;


namespace ASPNETHomework.Models.Requests.CustomerFolder
{
	/// <summary>
	/// Request for create a Customer.
	/// </summary>
	public class CreateCustomerRequest
	{
		/// <summary>
		/// Customer's first name.
		/// </summary>
		[Required]
		public string FirstName { get; set; }
		/// <summary>
		/// Customer's last name.
		/// </summary>
		[Required]
		public string LastName { get; set; }
		/// <summary>
		/// Customer's money.
		/// </summary>
		[Required]
		public float Money { get; set; }
		/// <summary>
		/// Customer's City
		/// </summary>
		[Required]
		public string City { get; set; }
	}
}
