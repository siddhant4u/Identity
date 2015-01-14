// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.Identity
{
    public class PasswordOptions<TUser> where TUser : class
    {
        /// <summary>
        ///     Minimum required length
        /// </summary>
        public int RequiredLength { get; set; } = 6;

        /// <summary>
        ///     Require a non letter or digit character
        /// </summary>
        public bool RequireNonLetterOrDigit { get; set; } = true;

        /// <summary>
        ///     Require a lower case letter ('a' - 'z')
        /// </summary>
        public bool RequireLowercase { get; set; } = true;

        /// <summary>
        ///     Require an upper case letter ('A' - 'Z')
        /// </summary>
        public bool RequireUppercase { get; set; } = true;

        /// <summary>
        ///     Require a digit ('0' - '9')
        /// </summary>
        public bool RequireDigit { get; set; } = true;

        public IPasswordHasher<TUser> Hasher { get; set; } = new PasswordHasher<TUser>();

        public IList<IPasswordValidator<TUser>> Validators { get; } = new List<IPasswordValidator<TUser>>();

    }
}