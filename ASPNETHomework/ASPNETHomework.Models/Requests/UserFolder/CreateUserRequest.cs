using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETHomework.Models.Requests.UserFolder
{
	public class CreateUserRequest
	{
		/// <summary>
		/// Name of user.
		/// </summary>
		[Required]
		[JsonPropertyName("username")]
		public string Login { get; set; }

		/// <summary>
		/// Password.
		/// </summary>
		[Required]
		[JsonPropertyName("password")]
		public string Password { get; set; }
	}
}
