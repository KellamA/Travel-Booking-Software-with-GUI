// <copyright file="RestaurantBooking.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Models;

namespace FinalExam.Models
{
    /// <summary>
    /// restraurant bookind implementation.
    /// </summary>
    public class RestaurantBooking : IBooking
    {
        /// <summary>
        /// Gets or Sets restaurant name.
        /// </summary>
        public string? RestaurantName { get; set; }

        /// <summary>
        /// Gets or Sets city.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or Sets reservation date.
        /// </summary>
        public DateTime ReservationDate { get; set; }

        /// <summary>
        /// Gets or Sets number of guests.
        /// </summary>
        public int NumberOfGuests { get; set; }

        /// <summary>
        /// Gets or Sets status of booking, deefault to available.
        /// </summary>
        public string Status { get; set; } = "Available";

        /// <summary>
        /// returns the booking details.
        /// </summary>
        /// <returns> booking details.</returns>
        public string GetBookingDetails()
        {
            return $"{this.RestaurantName} - {this.City} on {this.ReservationDate.ToShortDateString()} for {this.NumberOfGuests} guests [{this.Status}]";
        }

        /// <summary>
        /// simpplifies getting the booking detaiks.
        /// </summary>
        /// <returns>string of booking details.</returns>
        public override string ToString()
        {
            return this.GetBookingDetails();
        }
    }
}
