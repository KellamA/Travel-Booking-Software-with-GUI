// <copyright file="User.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Users
{
    /// <summary>
    /// class for the user progile.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or Sets Username of user.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or Sets password of user.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Gets or Sets first name of user.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or Sets lastname of user.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or Sets email of user.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or Sets phone number of user.
        /// </summary>
        public string? PhoneNumber { get; set; }
    }
}
