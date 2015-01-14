// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Identity
{
    public static class IdentityAuthenticationTypes
    {
        public static string ApplicationCookieAuthenticationType { get; set;  } = typeof(IdentityAuthenticationTypes).Namespace + ".Application";
        public static string ExternalCookieAuthenticationType { get; set; } = typeof(IdentityAuthenticationTypes).Namespace + ".External";
        public static string TwoFactorUserIdCookieAuthenticationType { get; set; } = typeof(IdentityAuthenticationTypes).Namespace + ".TwoFactorUserId";
        public static string TwoFactorRememberMeCookieAuthenticationType { get; set; } = typeof(IdentityAuthenticationTypes).Namespace + ".TwoFactorRemeberMe";
    }
}