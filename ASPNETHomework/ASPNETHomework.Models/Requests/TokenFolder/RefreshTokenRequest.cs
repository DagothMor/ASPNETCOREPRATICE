using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETHomework.Models.Requests.TokenFolder
{
    /// <summary>
    /// Refresh token request.
    /// </summary>
    public class RefreshTokenRequest
    {
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
