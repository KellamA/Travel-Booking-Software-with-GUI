// <copyright file="UserManager.cs" company="Kellam Adams">
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
    /// manmager to handle creating and logining in of suers.
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// list of users.
        /// </summary>
        private List<User> users = new List<User>();

        /// <summary>
        /// Gets The current User.
        /// </summary>
        public User? CurrentUser { get; private set; }

        /// <summary>
        /// Gets a value indicating whether user for is authenticated.
        /// </summary>
        public bool IsAuthenticated => this.CurrentUser != null;

        /// <summary>
        /// Function to register a new user.
        /// </summary>
        /// <param name="newUser"> users data.</param>
        /// <returns> successful or not.</returns>
        public bool Register(User newUser)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (this.users.Any(u => u.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Username already exists
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            this.users.Add(newUser);
            return true;
        }

        /// <summary>
        /// function to login.
        /// </summary>
        /// <param name="username"> username.</param>
        /// <param name="password"> password.</param>
        /// <returns> success or nah.</returns>
        public bool Login(string username, string password)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var user = this.users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            if (user != null)
            {
                this.CurrentUser = user;
                return true;
            }

            return false;
        }
    }
}
