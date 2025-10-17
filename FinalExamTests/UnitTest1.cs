// <copyright file="UnitTest1.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using FinalExam;
using FinalExam.Models;
using FinalExam.Services;
using FinalExam.Users;
using NUnit.Framework;

namespace FinalExamTests
{
    /// <summary>
    /// tests for the final exam.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// search service for test.
        /// </summary>
        private SearchService searchService;

        /// <summary>
        /// booking manager for tests.
        /// </summary>
        private BookingManager bookingManager;

        /// <summary>
        /// user manager for tests.
        /// </summary>
        private UserManager userManager;

        /// <summary>
        /// runs neccesary testing setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.searchService = new SearchService();
            this.bookingManager = new BookingManager();
            this.userManager = new UserManager();
        }

        // -------- Hotel Search Tests --------

        /// <summary>
        /// Base Case tests for a normal search if it returns soemthig.
        /// </summary>
        [Test]
        public void HotelSearch_BaseCase_ReturnsHotels()
        {
            var results = this.searchService.SearchHotels("Pullman", "Double", DateTime.Today, DateTime.Today.AddDays(1), 2);
            Assert.IsTrue(results.Count > 0);
        }

        /// <summary>
        /// Edge case tests whether empty critera still returns results.
        /// </summary>
        [Test]
        public void HotelSearch_EdgeCase_EmptyFiltersStillReturnResults()
        {
            var results = this.searchService.SearchHotels("", "", DateTime.Today, DateTime.Today.AddDays(1), 4);
            Assert.IsTrue(results.Count > 0);
        }

        /// <summary>
        /// tests when invalid inputs are netered to ensure nothign gets improperly given.
        /// </summary>
        [Test]
        public void HotelSearch_Exception_InvalidInput_ReturnsEmpty()
        {
            var results = this.searchService.SearchHotels("Mars", "Igloo", DateTime.Today.AddDays(5), DateTime.Today, -1);
            Assert.IsTrue(results.Count == 0);
        }

        // -------- Registration Tests --------

        /// <summary>
        /// normal user registration experience.
        /// </summary>
        [Test]
        public void RegisterUser_BaseCase_Successful()
        {
            var user = new User { Username = "jdoe", Password = "test", FirstName = "John", LastName = "Doe", Email = "jdoe@example.com", PhoneNumber = "1234567890" };
            var result = this.userManager.Register(user);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// edge case testin for long entries into the feilds to ensue they still work.
        /// </summary>
        [Test]
        public void RegisterUser_EdgeCase_LongFields_Successful()
        {
            var user = new User
            {
                Username = "longnameuser",
                Password = "longpassword",
                FirstName = new string('A', 50),
                LastName = new string('B', 50),
                Email = new string('C', 40) + "@example.com",
                PhoneNumber = "+1-9999999999",
            };
            var result = this.userManager.Register(user);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// ensues user cant elave empty feilds.
        /// </summary>
        [Test]
        public void RegisterUser_Exception_MissingFieldsOrDuplicate()
        {
            var user1 = new User { Username = "duplicate", Password = "pass", FirstName = "A", LastName = "B", Email = "a@b.com", PhoneNumber = "1" };
            var user2 = new User { Username = "duplicate", Password = "pass", FirstName = "C", LastName = "D", Email = "c@d.com", PhoneNumber = "2" };
            this.userManager.Register(user1);
            var result = this.userManager.Register(user2);
            Assert.IsFalse(result);
        }

        // -------- Booking Tests --------

        /// <summary>
        /// Normal booking scenario.
        /// </summary>
        [Test]
        public void Booking_AddBooking_BaseCase()
        {
            var booking = new FlightBooking { DepartureCity = "Pullman", ArrivalCity = "Seattle", DepartureDate = DateTime.Today, Airline = "Air WA", Price = 100 };
            this.bookingManager.AddBooking(booking);
            Assert.That(booking.Status, Is.EqualTo("Confirmed"));
            Assert.That(this.bookingManager.GetBookings(), Does.Contain(booking));
        }

        /// <summary>
        /// edge case with a multi room hotel.
        /// </summary>
        [Test]
        public void Booking_AddBooking_EdgeCase_MultiRoomHotel()
        {
            var booking = new HotelBooking { HotelName = "Grand", RoomType = "Suite", CheckInDate = DateTime.Today, CheckOutDate = DateTime.Today.AddDays(2), NumberOfGuests = 9, NumberOfRooms = 3 };
            this.bookingManager.AddBooking(booking);
            Assert.That(booking.Status, Is.EqualTo("Confirmed"));
            Assert.Contains(booking, this.bookingManager.GetBookings());
        }

        /// <summary>
        /// testing an exception when user is not logged in.
        /// </summary>
        [Test]
        public void Booking_AddBooking_Exception_NoUserLoggedIn()
        {
            var booking = new RestaurantBooking { RestaurantName = "Dine", City = "Pullman", ReservationDate = DateTime.Today, NumberOfGuests = 2 };

            // simulate booking attempt without login
            this.bookingManager.AddBooking(booking);
            Assert.That(booking.Status, Is.EqualTo("Confirmed"));
        }
    }
}