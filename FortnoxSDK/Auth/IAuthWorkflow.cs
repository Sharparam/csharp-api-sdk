﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fortnox.SDK.Auth
{
    /// <summary>
    /// Represents methods of OAuth 2.0 workflow.
    /// </summary>
    /// <remarks><see href="https://oauth.net/" /> and <see href="https://developer.fortnox.se/general/authentication/" /></remarks>
    public interface IStandardAuthWorkflow
    {
        /// <summary>
        /// Use this function exchange authorization code for an OAuth access token.
        /// </summary>
        /// <param name="authCode">OAuth 2 authorization code.</param>
        /// <param name="clientId">Client id given to you by Fortnox.</param>
        /// <param name="clientSecret">Client secret given to you by Fortnox.</param>
        /// <param name="redirectUri">Redirect URI configured at Fortnox.</param>
        /// <returns>OAuth 2 token info.</returns>
        /// <remarks>
        /// <para>The authorization code is valid for 10 minutes. It can only be used once.</para>
        /// <para>The token is valid for 10 minutes. It can be re-used several times.</para>
        /// </remarks>
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
        TokenInfo GetToken(string authCode, string clientId, string clientSecret, string redirectUri = null);

        /// <summary>
        /// Use this function exchange authorization code for an OAuth access token.
        /// </summary>
        /// <param name="authCode">OAuth 2 authorization code.</param>
        /// <param name="clientId">Client id given to you by Fortnox.</param>
        /// <param name="clientSecret">Client secret given to you by Fortnox.</param>
        /// <param name="redirectUri">Redirect URI configured at Fortnox.</param>
        /// <returns>OAuth 2 token information.</returns>
        /// <remarks>
        /// <para>The authorization code is valid for 10 minutes. It can only be used once.</para>
        /// <para>The token is valid for 10 minutes. It can be re-used several times.</para>
        /// </remarks>
        Task<TokenInfo> GetTokenAsync(string authCode, string clientId, string clientSecret, string redirectUri = null);

        /// <summary>
        /// Use this function to obtain new token info.
        /// Note, that the new refresh token is also generated by this action and the one used becomes invalid.
        /// </summary>
        /// <param name="refreshToken">OAuth 2 refresh token.</param>
        /// <param name="clientId">Client id given to you by Fortnox.</param>
        /// <param name="clientSecret">Client secret given to you by Fortnox.</param>
        /// <returns>OAuth 2 token information.</returns>
        /// <remarks>The refresh token is valid for 30 days. It can only be used once.</remarks>
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
        TokenInfo RefreshToken(string refreshToken, string clientId, string clientSecret);

        /// <summary>
        /// Use this function to obtain new token info.
        /// Note, that the new refresh token is also generated by this action and the one used becomes invalid.
        /// </summary>
        /// <param name="refreshToken">OAuth 2 refresh token.</param>
        /// <param name="clientId">Client id given to you by Fortnox.</param>
        /// <param name="clientSecret">Client secret given to you by Fortnox.</param>
        /// <returns>OAuth 2 token information.</returns>
        /// <remarks>The refresh token is valid for 30 days. It can only be used once.</remarks>
        Task<TokenInfo> RefreshTokenAsync(string refreshToken, string clientId, string clientSecret);

        /// <summary>
        /// Generates a state nonce for use with the <see cref="BuildAuthUri"/> method.
        /// </summary>
        /// <returns>A randomly-generated string.</returns>
        string GenerateState();

        /// <summary>
        /// Use this function to build the full URI for OAuth 2.0 workflow initialization.
        /// </summary>
        /// <param name="clientId">Client id given to you by Fortnox.</param>
        /// <param name="scopes">OAuth scopes to request.</param>
        /// <param name="state">The state parameter is used by the application to store request-specific data and/or
        /// prevent CSRF attacks. The authorization server will return the unmodified state value back to the application.</param>
        /// <param name="redirectUri">URI to redirect back to from Fortnox.</param>
        /// <returns>A URI.</returns>
        Uri BuildAuthUri(string clientId, IEnumerable<Scope> scopes, string state, string redirectUri = null);
    }

    /// <summary>
    /// Represents methods of a Fortnox legacy auth workflow.
    /// This is deprecated and will be removed.
    /// </summary>
    [Obsolete("2021-12-09: End-of-life for the static authorization. Use StandardAuth.")]
    public interface IStaticTokenAuthWorkflow
    {
        /// <summary>
        /// Use this function to activate new integration and retrieve Access-Token.
        /// </summary>
        /// <param name="authCode">The API-code (authorization code) given to you by Fortnox.</param>
        /// <param name="clientSecret">The Client-Secret code given to you by Fortnox.</param>
        /// <returns>The Access-Token to use with Fortnox.</returns>
        /// <remarks>Note that an authorization-code can be used only once. Save the retrieved Access-Token in order to use it for FortnoxClient.</remarks>
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
        string GetToken(string authCode, string clientSecret);

        /// <summary>
        /// Use this function to activate new integration and retrieve Access-Token.
        /// </summary>
        /// <param name="authCode">The API-code (authorization code) given to you by Fortnox.</param>
        /// <param name="clientSecret">The Client-Secret code given to you by Fortnox.</param>
        /// <returns>The Access-Token to use with Fortnox.</returns>
        /// <remarks>Note that an authorization-code can be used only once. Save the retrieved Access-Token in order to use it for FortnoxClient.</remarks>
        Task<string> GetTokenAsync(string authCode, string clientSecret);
    }
}
