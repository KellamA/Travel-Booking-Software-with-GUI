// <copyright file="IBooking.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    /// <summary>
    /// interface that all bookings build off of.
    /// </summary>
    public interface IBooking
    {
        /// <summary>
        /// Gets or Sets status of the booking.
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// gets booking detals.
        /// </summary>
        /// <returns> booking detals. </returns>
        string GetBookingDetails();
    }
}
