﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace ASPNETHomework.Models.Response.LoginFolder
{
    /// <summary>
    /// Login response.
    /// </summary>
    public class LoginResult
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("originalUserName")]
        public string OriginalUserName { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
