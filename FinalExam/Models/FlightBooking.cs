// <copyright file="FlightBooking.cs" company="Kellam Adams">
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
    /// implementation of flight booking.
    /// </summary>
    public class FlightBooking : IBooking
    {
        /// <summary>
        /// Gets or Sets departure city.
        /// </summary>
        public string? DepartureCity { get; set; }

        /// <summary>
        /// Gets or Sets arrival city.
        /// </summary>
        public string? ArrivalCity { get; set; }

        /// <summary>
        /// Gets or Sets departure date.
        /// </summary>
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Gets or Sets airline.
        /// </summary>
        public string? Airline { get; set; }

        /// <summary>
        /// Gets or Sets price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets status.
        /// </summary>
        public string Status { get; set; } = "Available";

        /// <summary>
        /// gets booking details and converts to string.
        /// </summary>
        /// <returns> string of booking details.</returns>
        public string GetBookingDetails()
        {
            return $"{this.Airline}: {this.DepartureCity} → {this.ArrivalCity} on {this.DepartureDate.ToShortDateString()} - ${this.Price} [{this.Status}]";
        }

        /// <summary>
        /// override to get booking details.
        /// </summary>
        /// <returns> string of booking details.</returns>
        public override string ToString()
        {
            return this.GetBookingDetails();
        }
    }
}
