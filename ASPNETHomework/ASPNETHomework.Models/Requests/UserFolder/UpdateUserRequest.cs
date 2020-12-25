using ASPNETHomework.Models.DTO;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETHomework.Models.Requests.UserFolder
{
	public class UpdateUserRequest:CreateUserRequest
	{
		/// <summary>
		/// Entity identification.
		/// </summary>
		[Required]
		public int Id { get; set; }
	}
}
