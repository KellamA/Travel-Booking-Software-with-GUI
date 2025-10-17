// <copyright file="SearchService.cs" company="Kellam Adams">
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
    /// service to search for various bookings. I also keep my mock data in here as its easiest, ideally this would be populated from a server.
    /// </summary>
    public class SearchService
    {
        /// <summary>
        /// a dictionary to tell the capacity of each type of hotel room.
        /// </summary>
        private Dictionary<string, int> roomTypeCapacities = new Dictionary<string, int>
    {
        { "Single", 1 },
        { "Double", 2 },
        { "Suite", 4 },
    };

        /// <summary>
        /// function to seartch for restaurants.
        /// </summary>
        /// <param name="city"> city. </param>
        /// <param name="reservationDate"> res date.</param>
        /// <param name="numberOfGuests"> num of guests.</param>
        /// <returns>the restaurants matchign the criteria.</returns>
        public List<RestaurantBooking> SearchRestaurants(string city, DateTime? reservationDate, int? numberOfGuests)
        {
            var restaurants = new List<RestaurantBooking>
            {
                new RestaurantBooking
                {
                    RestaurantName = "Zeppos",
                    City = "Pullman",
                    ReservationDate = DateTime.Today,
                    NumberOfGuests = 2,
                },
                new RestaurantBooking
                {
                    RestaurantName = "Coug Country",
                    City = "Pullman",
                    ReservationDate = DateTime.Today,
                    NumberOfGuests = 4,
                },
            };

            return restaurants.Where(r =>
                (string.IsNullOrEmpty(city) || r.City.Equals(city, StringComparison.OrdinalIgnoreCase)) &&
                (!reservationDate.HasValue || r.ReservationDate.Date == reservationDate.Value.Date) &&
                (!numberOfGuests.HasValue || r.NumberOfGuests >= numberOfGuests.Value))
            .ToList();
        }

        /// <summary>
        /// Gets all flights.
        /// </summary>
        /// <returns> list of flights.</returns>
        public List<FlightBooking> GetAllFlights()
        {
            return new List<FlightBooking>
    {
            new FlightBooking
         {
            DepartureCity = "Pullman",
            ArrivalCity = "Seattle",
            DepartureDate = DateTime.Today,
            Airline = "Air Washington",
            Price = 150.00m,
         },
            new FlightBooking
            {
            DepartureCity = "Pullman",
            ArrivalCity = "Seattle",
            DepartureDate = DateTime.Today,
            Airline = "Pacific Skies",
            Price = 175.50m,
            },
    };
        }

        /// <summary>
        /// searching for flights.
        /// </summary>
        /// <param name="departureCity"> departure city. </param>
        /// <param name="arrivalCity"> arrival city. </param>
        /// <param name="departureDate"> departure date.</param>
        /// <returns> list of flights matchign criteria.</returns>
        public List<FlightBooking> SearchFlights(string departureCity, string arrivalCity, DateTime departureDate)
        {
            var flights = new List<FlightBooking>
            {
                // Placeholder flight bookings
                new FlightBooking
                {
                    DepartureCity = "Pullman",
                    ArrivalCity = "Seattle",
                    DepartureDate = departureDate,
                    Airline = "Air Washington",
                    Price = 150.00m,
                },
                new FlightBooking
                {
                    DepartureCity = "Pullman",
                    ArrivalCity = "Seattle",
                    DepartureDate = departureDate,
                    Airline = "Pacific Skies",
                    Price = 175.50m,
                },
            };

            // Filter flights based on search criteria
            return flights.FindAll(f =>
                f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase) &&
                f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase) &&
                f.DepartureDate.Date == departureDate.Date);
        }

        /// <summary>
        /// function to search for hotels.
        /// </summary>
        /// <param name="city"> city.</param>
        /// <param name="roomType"> type of room.</param>
        /// <param name="checkInDate"> check in date.</param>
        /// <param name="checkOutDate"> check out date.</param>
        /// <param name="numberOfGuests"> number of guests.</param>
        /// <returns> list of hotels matching criteria.</returns>
        public List<HotelBooking> SearchHotels(string city, string roomType, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests)
        {
            // Sample data
            var hotels = new List<HotelBooking>
        {
            new HotelBooking
            {
                HotelName = "Grand Pullman Hotel",
                City = "Pullman",
                RoomType = roomType,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                NumberOfGuests = numberOfGuests,
                NumberOfRooms = this.CalculateNumberOfRooms(roomType, numberOfGuests),
                Status = "Available",
            },
        };

            return hotels.Where(h =>
                (string.IsNullOrEmpty(city) || h.City.Equals(city, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(roomType) || h.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase)) &&
                h.CheckInDate == checkInDate &&
                h.CheckOutDate == checkOutDate)
            .ToList();
        }

        /// <summary>
        /// to calculate number of rooms.
        /// </summary>
        /// <param name="roomType"> type of rooms.</param>
        /// <param name="numberOfGuests"> number of guests.</param>
        /// <returns> number of rooms.</returns>
        private int CalculateNumberOfRooms(string roomType, int numberOfGuests)
        {
            if (this.roomTypeCapacities.TryGetValue(roomType, out int capacity))
            {
                return (int)Math.Ceiling((double)numberOfGuests / capacity);
            }

            return 1; // Default to 1 room if room type is unknown
        }
    }
}
