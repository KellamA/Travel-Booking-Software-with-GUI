// <copyright file="BookingManager.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Services
{
    /// <summary>
    /// manages the bookings.
    /// </summary>
    public class BookingManager
    {
        /// <summary>
        /// bookings.
        /// </summary>
        private List<IBooking> bookings = new List<IBooking>();

        /// <summary>
        /// adds bookings.
        /// </summary>
        /// <param name="booking"> bookings.</param>
        public void AddBooking(IBooking booking)
        {
            booking.Status = "Confirmed";
            this.bookings.Add(booking);
        }

        /// <summary>
        /// gets bookings.
        /// </summary>
        /// <returns> bookings.</returns>
        public List<IBooking> GetBookings()
        {
            return this.bookings;
        }

        /// <summary>
        /// finnction to cancel a booking.
        /// </summary>
        /// <param name="booking"> booking.</param>
        public void CancelBooking(IBooking booking)
        {
            var existingBooking = this.bookings.FirstOrDefault(b => b == booking);
            if (existingBooking != null)
            {
                existingBooking.Status = "Canceled";
            }
        }
    }
}
