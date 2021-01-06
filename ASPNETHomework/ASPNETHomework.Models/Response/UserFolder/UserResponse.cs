using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ASPNETHomework.Models.Response.UserFolder
{
	public class UserResponse
	{
		[JsonPropertyName("username")]
		public string Login { get; set; }

		[JsonPropertyName("role")]
		public string Role { get; set; }
	}
}
