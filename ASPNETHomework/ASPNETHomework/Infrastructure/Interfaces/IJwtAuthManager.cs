﻿using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.IdentityModel.Tokens;

namespace ASPNETHomework.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface for Auth Manager.
    /// </summary>
    public interface IJwtAuthManager
    {
        /// <summary>
        /// RT dict.
        /// </summary>
        IImmutableDictionary<string, RefreshToken> UsersRefreshTokensReadOnlyDictionary { get; }

        /// <summary>
        /// Generate tokens.
        /// </summary>
        /// <param name="username">User names.</param>
        /// <param name="claims">Claim's array.</param>
        /// <param name="now">Now date.</param>
        /// <returns><see cref="JwtAuthResult"/></returns>
        JwtAuthResult GenerateTokens(string username, Claim[] claims, DateTime now);

        /// <summary>
        /// Go refresh.
        /// </summary>
        /// <param name="refreshToken">RT.</param>
        /// <param name="accessToken">AT.</param>
        /// <param name="now">Now date.</param>
        /// <returns></returns>
        JwtAuthResult Refresh(string refreshToken, string accessToken, DateTime now);

        /// <summary>
        /// Delete RT.
        /// </summary>
        /// <param name="now">Now date.</param>
        void RemoveExpiredRefreshTokens(DateTime now);

        /// <summary>
        /// Refresh by user.
        /// </summary>
        /// <param name="userName">User name.</param>
        void RemoveRefreshTokenByUserName(string userName);

        /// <summary>
        /// Decode token.
        /// </summary>
        /// <param name="token">AT token.</param>
        (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token);
    }
}
