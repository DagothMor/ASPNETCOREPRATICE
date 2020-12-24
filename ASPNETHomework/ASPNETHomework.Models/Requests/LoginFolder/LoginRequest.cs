using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace ASPNETHomework.Models.Requests.LoginFolder
{
    /// <summary>
    /// Login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Name of user.
        /// </summary>
        [Required]
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
