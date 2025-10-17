// <copyright file="HotelBooking.cs" company="Kellam Adams">
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
    /// implementation for hotel booking.
    /// </summary>
    public class HotelBooking : IBooking
    {
        /// <summary>
        /// Gets or Sets name of hotel.
        /// </summary>
        public string? HotelName { get; set; }

        /// <summary>
        /// Gets or Sets city.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or Sets room type.
        /// </summary>
        public string? RoomType { get; set; } // e.g., "Single", "Double", "Suite"

        /// <summary>
        /// Gets or Sets checkin date.
        /// </summary>
        public DateTime CheckInDate { get; set; }

        /// <summary>
        /// Gets or Sets checkout date.
        /// </summary>
        public DateTime CheckOutDate { get; set; }

        /// <summary>
        /// Gets or Sets Number of guests.
        /// </summary>
        public int NumberOfGuests { get; set; }

        /// <summary>
        /// Gets or Sets Number of rooms.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Gets or Sets status default is available.
        /// </summary>
        public string Status { get; set; } = "Available";

        /// <summary>
        /// gets the details of the booking.
        /// </summary>
        /// <returns> booking details.</returns>
        public string GetBookingDetails()
        {
            return $"{this.HotelName} - {this.RoomType} Room(s): {this.NumberOfRooms}, Guests: {this.NumberOfGuests}, {this.CheckInDate.ToShortDateString()} to {this.CheckOutDate.ToShortDateString()} [{this.Status}]";
        }

        /// <summary>
        /// override for to string to make getting booking details easier.
        /// </summary>
        /// <returns> string of booking details.</returns>
        public override string ToString()
        {
            return this.GetBookingDetails();
        }
    }
}
