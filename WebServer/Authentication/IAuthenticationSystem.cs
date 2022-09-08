﻿using Ceen;
using Weedwacker.WebServer.Database;
using Weedwacker.WebServer.Authentication.Objects;

namespace Weedwacker.WebServer.Authentication
{
    internal interface IAuthenticationSystem
    {

        ///<summary>
        ///Called when a user requests to make an account.
        ///</summary>
        ///<param name="username"> The provided username.</param>
        ///<param name="password">The provided password. (SHA-256'ed)</param>
        void CreateAccount(string username, string password);

        ///<summary>
        ///Called when a user requests to reset their password.
        ///</summary>
        ///<param name="username">The username of the account to reset. (SHA-256'ed)</param>
        void ResetPassword(string username);

        ///<summary>
        ///Called by plugins to internally verify a user's identity.
        ///</summary>
        ///<param name="details"> A unique identifier to identify the user. (For example: a JWT token)</param>
        ///<returns>The user's account if the verification was successful, null if the user was unable to be verified.</returns>
        Account VerifyUser(string details);

        ///<summary>
        ///This is the authenticator used for password authentication.
        ///</summary>
        ///<returns>An authenticator.</returns>
        IAuthenticator<LoginResultJson> GetPasswordAuthenticator();

        ///<summary>
        ///This is the authenticator used for token authentication.
        ///</summary>
        ///<returns>An authenticator.</returns>
        IAuthenticator<LoginResultJson> GetTokenAuthenticator();

        ///<summary>
        ///This is the authenticator used for session authentication.
        ///</summary>
        ///<returns>An authenticator.</returns>
        IAuthenticator<ComboTokenResJson> GetSessionKeyAuthenticator();

        ///<summary>
        ///This is the authenticator used for handling external authentication requests.
        ///</summary>
        ///<returns>An authenticator.</returns>
        IExternalAuthenticator GetExternalAuthenticator();

        ///<summary>
        ///This is the authenticator used for handling OAuth authentication requests.
        ///</summary>
        ///<returns>An authenticator.</returns>
        IOAuthAuthenticator GetOAuthAuthenticator();

        ///<summary>
        ///Generates an authentication request from a <see cref="LoginAccountRequestJson"/> object.
        ///</summary>
        ///<param name="ctx">The Ceen context.</param>
        ///<param name="jsonData">The JSON data.</param>
        ///<returns>An authenticator.</returns>
        static AuthenticationRequest FromPasswordRequest(IHttpContext ctx, LoginAccountRequestJson jsonData)
        {
            return new AuthenticationRequest(ctx, jsonData);
        }

        ///<summary>
        ///Generates an authentication request from a <see cref="LoginTokenRequestJson"/> object.
        ///</summary>
        ///<param name="ctx">The Ceen context.</param>
        ///<param name="jsonData">The JSON data.</param>
        ///<returns>An authenticator.</returns>
        static AuthenticationRequest FromTokenRequest(IHttpContext ctx, LoginTokenRequestJson jsonData)
        {
            return new AuthenticationRequest(ctx, jsonData); ;
        }

        ///<summary>
        ///Generates an authentication request from a <see cref="ComboTokenReqJson"/> object.
        ///</summary>
        ///<param name="ctx">The Ceen context.</param>
        ///<param name="jsonData">The JSON data.</param>
        ///<returns>An authenticator.</returns>
        static AuthenticationRequest FromComboTokenRequest(IHttpContext ctx, ComboTokenReqJson jsonData,
                                                           ComboTokenReqJson.LoginTokenData tokenData)
        {
            return new AuthenticationRequest(ctx, jsonData, tokenData);
        }

        ///<summary>
        ///Generates an authentication request from a <see cref="IHttpContext"/> object.
        ///</summary>
        ///<param name="ctx">The Ceen context.</param>
        ///<returns>An authentication request.</returns>
        static AuthenticationRequest FromExternalRequest(IHttpContext ctx)
        {
            return new AuthenticationRequest(ctx);
        }
    }
}
