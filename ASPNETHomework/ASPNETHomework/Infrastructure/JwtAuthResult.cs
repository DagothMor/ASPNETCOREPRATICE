using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASPNETHomework.Infrastructure
{
    /// <summary>
    /// Tokens result.
    /// </summary>
    public class JwtAuthResult
    {
        /// <summary>
        /// AT.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// RT.
        /// </summary>
        [JsonPropertyName("refreshToken")]
        public RefreshToken RefreshToken { get; set; }
    }
}
