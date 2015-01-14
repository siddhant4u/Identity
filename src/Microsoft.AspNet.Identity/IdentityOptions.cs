// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Identity
{
    /// <summary>
    ///     Configuration for identity
    /// </summary>
    public class IdentityOptions<TUser> where TUser : class
    {
        public ClaimsIdentityOptions ClaimsIdentity { get; set; } = new ClaimsIdentityOptions();

        public UserOptions<TUser> User { get; set; } = new UserOptions<TUser>();

        public PasswordOptions<TUser> Password { get; set; } = new PasswordOptions<TUser>();

        public LockoutOptions Lockout { get; set; } = new LockoutOptions();

        public SignInOptions SignIn { get; set; } = new SignInOptions();

        public TimeSpan SecurityStampValidationInterval { get; set; } = TimeSpan.FromMinutes(30);

        public string EmailConfirmationTokenProvider { get; set; } = Resources.DefaultTokenProvider;

        public string PasswordResetTokenProvider { get; set; } = Resources.DefaultTokenProvider;

        public string ChangeEmailTokenProvider { get; set; } = Resources.DefaultTokenProvider;

        /// <summary>
        ///     Used to normalize user names and emails for uniqueness
        /// </summary>
        public ILookupNormalizer KeyNormalizer { get; set; } = new UpperInvariantLookupNormalizer();

        /// <summary>
        ///     Used to generate public API error messages
        /// </summary>
        public IdentityErrorDescriber ErrorDescriber { get; set; } = new IdentityErrorDescriber();


        public static string ApplicationCookieAuthenticationType { get; set; } = typeof(IdentityUser).Namespace + ".Application";
        public static string ExternalCookieAuthenticationType { get; set; } = typeof(IdentityUser).Namespace + ".External";
        public static string TwoFactorUserIdCookieAuthenticationType { get; set; } = typeof(IdentityUser).Namespace + ".TwoFactorUserId";
        public static string TwoFactorRememberMeCookieAuthenticationType { get; set; } = typeof(IdentityUser).Namespace + ".TwoFactorRemeberMe";
    }
}