// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.Identity
{
    public class UserOptions<TUser> where TUser : class
    {
        public string UserNameValidationRegex { get; set; } = "^[a-zA-Z0-9@_\\.]+$";

        /// <summary>
        ///     If set, enforces that emails are non empty, valid, and unique
        /// </summary>
        public bool RequireUniqueEmail { get; set; }

        public IList<IUserValidator<TUser>> Validators { get; } = new List<IUserValidator<TUser>>();
    }
}