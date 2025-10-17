// <copyright file="MainForm.cs" company="Kellam Adams">
// Copyright (c) {CS 321 Class WSU}. All rights reserved.
// </copyright>

using FinalExam.Models;
using FinalExam.Services;
using FinalExam.Users;

namespace FinalExam
{
    /// <summary>
    /// the ui form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Instantiates a search servuce.
        /// </summary>
        private readonly SearchService searchService = new SearchService();

        /// <summary>
        /// instantiates a booking manager.
        /// </summary>
        private readonly BookingManager bookingManager = new BookingManager();

        /// <summary>
        /// instantiates a user manager.
        /// </summary>
        private readonly UserManager userManager = new UserManager();

        /// <summary>
        /// list of all flights.
        /// </summary>
        private List<FlightBooking> allFlights;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// main cnstructor.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.allFlights = this.searchService.GetAllFlights();
        }

        /// <summary>
        /// I dont rmemebr why this is here, prob could remove...
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// assists in switching the UI view.
        /// </summary>
        /// <param name="panelToShow"> the chosen panel to show.</param>
        private void ShowPanel(Panel panelToShow)
        {
            this.panelSearch.Visible = false;
            this.panelBookings.Visible = false;
            this.panelLogin.Visible = false;

            panelToShow.Visible = true;
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.ShowPanel(this.panelSearch);
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnBookings_Click(object sender, EventArgs e)
        {
            this.ShowPanel(this.panelBookings);
            this.LoadBookings();
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            this.ShowPanel(this.panelLogin);
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnSearchFlights_Click(object sender, EventArgs e)
        {
            string departureCity = this.txtDepartureCity.Text.Trim();
            string arrivalCity = this.txtArrivalCity.Text.Trim();
            DateTime? departureDate = this.dtpDepartureDate.Checked ? this.dtpDepartureDate.Value.Date : (DateTime?)null;

            var results = this.allFlights.Where(f =>
                (string.IsNullOrEmpty(departureCity) || f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(arrivalCity) || f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase)) &&
                (!departureDate.HasValue || f.DepartureDate.Date == departureDate.Value))
            .ToList();

            this.lstSearchResults.Items.Clear();
            foreach (var flight in results)
            {
                this.lstSearchResults.Items.Add(flight);
            }
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            if (!this.userManager.IsAuthenticated)
            {
                MessageBox.Show("Please log in to make a booking.");
                return;
            }

            if (this.lstSearchResults.SelectedItem is IBooking selectedBooking)
            {
                this.bookingManager.AddBooking(selectedBooking);
                MessageBox.Show("Booking confirmed!");
            }
            else
            {
                MessageBox.Show("Please select a booking to confirm.");
            }
        }

        /// <summary>
        /// method to load bookings.
        /// </summary>
        private void LoadBookings()
        {
            this.lstBookings.Items.Clear();
            var bookings = this.bookingManager.GetBookings();
            foreach (var booking in bookings)
            {
                this.lstBookings.Items.Add(booking);
            }
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            if (this.lstBookings.SelectedItem is IBooking selectedBooking)
            {
                this.bookingManager.CancelBooking(selectedBooking);
                MessageBox.Show("Booking canceled successfully!");
                this.LoadBookings(); // Refresh the bookings list
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.");
            }
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text;
            string password = this.txtPassword.Text;

            if (this.userManager.Login(username, password))
            {
                MessageBox.Show("Login successful!");
                this.UpdateUIForAuthenticatedUser();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text;
            string firstName = this.txtFirstName.Text.Trim();
            string lastName = this.txtLastName.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            string phoneNumber = this.txtPhoneNumber.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            var newUser = new User
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
            };

            // Attempt to register the user
            if (this.userManager.Register(newUser))
            {
                MessageBox.Show("Registration successful! Please log in.");
            }
            else
            {
                MessageBox.Show("Username already exists.");
            }
        }

        /// <summary>
        /// updates ui for authenticated user.
        /// </summary>
        private void UpdateUIForAuthenticatedUser()
        {
            this.btnAddBooking.Enabled = this.userManager.IsAuthenticated;
            this.btnCancelBooking.Enabled = this.userManager.IsAuthenticated;
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void PanelSearch_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnSearchHotels_Click(object sender, EventArgs e)
        {
            string city = this.txtHotelCity.Text.Trim();
            string? roomType = this.cmbRoomType.SelectedItem?.ToString();
            DateTime checkInDate = this.dtpCheckInDate.Value.Date;
            DateTime checkOutDate = this.dtpCheckOutDate.Value.Date;

            bool isGuestsValid = int.TryParse(this.txtNumberOfSleepers.Text.Trim(), out int numberOfGuests);
            if (!isGuestsValid || numberOfGuests <= 0)
            {
                MessageBox.Show("Please enter a valid number of guests.");
                return;
            }

#pragma warning disable CS8604 // Possible null reference argument.
            var results = this.searchService.SearchHotels(city, roomType, checkInDate, checkOutDate, numberOfGuests);
#pragma warning restore CS8604 // Possible null reference argument.

            this.lstSearchResults.Items.Clear();
            foreach (var hotel in results)
            {
                this.lstSearchResults.Items.Add(hotel);
            }
        }

        /// <summary>
        /// button triggered by clicking.
        /// </summary>
        /// <param name="sender"> sender.</param>
        /// <param name="e"> event.</param>
        private void BtnSearchRestaurant_Click(object sender, EventArgs e)
        {
            string city = this.txtRestaurantCity.Text.Trim();
            DateTime? reservationDate = this.dtpReservationDate.Checked ? this.dtpReservationDate.Value.Date : (DateTime?)null;
            int? numberOfGuests = int.TryParse(this.txtNumberOfGuests.Text.Trim(), out int guests) ? guests : (int?)null;

            var results = this.searchService.SearchRestaurants(city, reservationDate, numberOfGuests);

            this.lstSearchResults.Items.Clear();
            foreach (var restaurant in results)
            {
                this.lstSearchResults.Items.Add(restaurant);
            }
        }
    }
}
