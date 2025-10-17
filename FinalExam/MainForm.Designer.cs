namespace FinalExam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSearch = new Panel();
            gbRestaurantSearch = new GroupBox();
            dtpReservationDate = new DateTimePicker();
            RestaurantLocation = new Label();
            ReservationDate = new Label();
            btnSearchRestaurant = new Button();
            txtRestaurantCity = new TextBox();
            NumberOfGuests = new Label();
            txtNumberOfGuests = new TextBox();
            gbHotelSearch = new GroupBox();
            HotelCity = new Label();
            txtHotelCity = new TextBox();
            NumberofGuestshotel = new Label();
            txtNumberOfSleepers = new TextBox();
            btnSearchHotel = new Button();
            gbFlight = new GroupBox();
            dtpDepartureDate = new DateTimePicker();
            btnSearchFlights = new Button();
            DepartureDate = new Label();
            txtArrivalCity = new TextBox();
            ArrivalCity = new Label();
            txtDepartureCity = new TextBox();
            DepartureCity = new Label();
            btnAddBooking = new Button();
            lstSearchResults = new ListBox();
            panelBookings = new Panel();
            btnCancelBooking = new Button();
            lstBookings = new ListBox();
            btnBookings = new Button();
            btnSearch = new Button();
            btnProfile = new Button();
            panelLogin = new Panel();
            txtPhoneNumber = new TextBox();
            PhoneNumber = new Label();
            txtEmail = new TextBox();
            Email = new Label();
            txtLastName = new TextBox();
            LastName = new Label();
            txtFirstName = new TextBox();
            FirstName = new Label();
            RegInfo = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            Password = new Label();
            txtUserName = new TextBox();
            UserName = new Label();
            cmbRoomType = new ComboBox();
            RoomType = new Label();
            dtpCheckInDate = new DateTimePicker();
            CheckinDate = new Label();
            CheckoutDate = new Label();
            dtpCheckOutDate = new DateTimePicker();
            panelSearch.SuspendLayout();
            gbRestaurantSearch.SuspendLayout();
            gbHotelSearch.SuspendLayout();
            gbFlight.SuspendLayout();
            panelBookings.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(gbRestaurantSearch);
            panelSearch.Controls.Add(gbHotelSearch);
            panelSearch.Controls.Add(gbFlight);
            panelSearch.Controls.Add(btnAddBooking);
            panelSearch.Controls.Add(lstSearchResults);
            panelSearch.Location = new Point(0, 29);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(800, 420);
            panelSearch.TabIndex = 0;
            panelSearch.Paint += PanelSearch_Paint;
            // 
            // gbRestaurantSearch
            // 
            gbRestaurantSearch.Controls.Add(dtpReservationDate);
            gbRestaurantSearch.Controls.Add(RestaurantLocation);
            gbRestaurantSearch.Controls.Add(ReservationDate);
            gbRestaurantSearch.Controls.Add(btnSearchRestaurant);
            gbRestaurantSearch.Controls.Add(txtRestaurantCity);
            gbRestaurantSearch.Controls.Add(NumberOfGuests);
            gbRestaurantSearch.Controls.Add(txtNumberOfGuests);
            gbRestaurantSearch.Location = new Point(3, 136);
            gbRestaurantSearch.Name = "gbRestaurantSearch";
            gbRestaurantSearch.Size = new Size(793, 47);
            gbRestaurantSearch.TabIndex = 26;
            gbRestaurantSearch.TabStop = false;
            gbRestaurantSearch.Text = "Restaurant Search";
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.Location = new Point(481, 18);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(191, 23);
            dtpReservationDate.TabIndex = 10;
            // 
            // RestaurantLocation
            // 
            RestaurantLocation.AutoSize = true;
            RestaurantLocation.Location = new Point(10, 23);
            RestaurantLocation.Name = "RestaurantLocation";
            RestaurantLocation.Size = new Size(85, 15);
            RestaurantLocation.TabIndex = 17;
            RestaurantLocation.Text = "Location (City)";
            // 
            // ReservationDate
            // 
            ReservationDate.AutoSize = true;
            ReservationDate.Location = new Point(380, 22);
            ReservationDate.Name = "ReservationDate";
            ReservationDate.Size = new Size(95, 15);
            ReservationDate.TabIndex = 9;
            ReservationDate.Text = "Reservation Date";
            // 
            // btnSearchRestaurant
            // 
            btnSearchRestaurant.Location = new Point(677, 18);
            btnSearchRestaurant.Name = "btnSearchRestaurant";
            btnSearchRestaurant.Size = new Size(109, 23);
            btnSearchRestaurant.TabIndex = 23;
            btnSearchRestaurant.Text = "Search Restaurant";
            btnSearchRestaurant.UseVisualStyleBackColor = true;
            btnSearchRestaurant.Click += BtnSearchRestaurant_Click;
            // 
            // txtRestaurantCity
            // 
            txtRestaurantCity.Location = new Point(99, 20);
            txtRestaurantCity.Name = "txtRestaurantCity";
            txtRestaurantCity.Size = new Size(100, 23);
            txtRestaurantCity.TabIndex = 18;
            // 
            // NumberOfGuests
            // 
            NumberOfGuests.AutoSize = true;
            NumberOfGuests.Location = new Point(201, 23);
            NumberOfGuests.Name = "NumberOfGuests";
            NumberOfGuests.Size = new Size(66, 15);
            NumberOfGuests.TabIndex = 19;
            NumberOfGuests.Text = "# of Guests";
            // 
            // txtNumberOfGuests
            // 
            txtNumberOfGuests.Location = new Point(274, 18);
            txtNumberOfGuests.Name = "txtNumberOfGuests";
            txtNumberOfGuests.Size = new Size(100, 23);
            txtNumberOfGuests.TabIndex = 20;
            // 
            // gbHotelSearch
            // 
            gbHotelSearch.Controls.Add(CheckoutDate);
            gbHotelSearch.Controls.Add(dtpCheckOutDate);
            gbHotelSearch.Controls.Add(CheckinDate);
            gbHotelSearch.Controls.Add(dtpCheckInDate);
            gbHotelSearch.Controls.Add(RoomType);
            gbHotelSearch.Controls.Add(cmbRoomType);
            gbHotelSearch.Controls.Add(HotelCity);
            gbHotelSearch.Controls.Add(txtHotelCity);
            gbHotelSearch.Controls.Add(NumberofGuestshotel);
            gbHotelSearch.Controls.Add(txtNumberOfSleepers);
            gbHotelSearch.Controls.Add(btnSearchHotel);
            gbHotelSearch.Location = new Point(3, 49);
            gbHotelSearch.Name = "gbHotelSearch";
            gbHotelSearch.Size = new Size(793, 81);
            gbHotelSearch.TabIndex = 25;
            gbHotelSearch.TabStop = false;
            gbHotelSearch.Text = "Hotel Search";
            // 
            // HotelCity
            // 
            HotelCity.AutoSize = true;
            HotelCity.Location = new Point(9, 21);
            HotelCity.Name = "HotelCity";
            HotelCity.Size = new Size(85, 15);
            HotelCity.TabIndex = 10;
            HotelCity.Text = "Location (City)";
            // 
            // txtHotelCity
            // 
            txtHotelCity.Location = new Point(98, 18);
            txtHotelCity.Name = "txtHotelCity";
            txtHotelCity.Size = new Size(100, 23);
            txtHotelCity.TabIndex = 11;
            // 
            // NumberofGuestshotel
            // 
            NumberofGuestshotel.AutoSize = true;
            NumberofGuestshotel.Location = new Point(204, 21);
            NumberofGuestshotel.Name = "NumberofGuestshotel";
            NumberofGuestshotel.Size = new Size(66, 15);
            NumberofGuestshotel.TabIndex = 12;
            NumberofGuestshotel.Text = "# of Guests";
            // 
            // txtNumberOfSleepers
            // 
            txtNumberOfSleepers.Location = new Point(273, 16);
            txtNumberOfSleepers.Name = "txtNumberOfSleepers";
            txtNumberOfSleepers.Size = new Size(100, 23);
            txtNumberOfSleepers.TabIndex = 13;
            // 
            // btnSearchHotel
            // 
            btnSearchHotel.Location = new Point(600, 33);
            btnSearchHotel.Name = "btnSearchHotel";
            btnSearchHotel.Size = new Size(185, 23);
            btnSearchHotel.TabIndex = 16;
            btnSearchHotel.Text = "Search Hotel";
            btnSearchHotel.UseVisualStyleBackColor = true;
            btnSearchHotel.Click += BtnSearchHotels_Click;
            // 
            // gbFlight
            // 
            gbFlight.Controls.Add(dtpDepartureDate);
            gbFlight.Controls.Add(btnSearchFlights);
            gbFlight.Controls.Add(DepartureDate);
            gbFlight.Controls.Add(txtArrivalCity);
            gbFlight.Controls.Add(ArrivalCity);
            gbFlight.Controls.Add(txtDepartureCity);
            gbFlight.Controls.Add(DepartureCity);
            gbFlight.Location = new Point(3, 3);
            gbFlight.Name = "gbFlight";
            gbFlight.Size = new Size(793, 42);
            gbFlight.TabIndex = 24;
            gbFlight.TabStop = false;
            gbFlight.Text = "Flight Search";
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Location = new Point(474, 15);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(200, 23);
            dtpDepartureDate.TabIndex = 8;
            // 
            // btnSearchFlights
            // 
            btnSearchFlights.Location = new Point(677, 15);
            btnSearchFlights.Name = "btnSearchFlights";
            btnSearchFlights.Size = new Size(108, 23);
            btnSearchFlights.TabIndex = 6;
            btnSearchFlights.Text = "Search Flights";
            btnSearchFlights.UseVisualStyleBackColor = true;
            btnSearchFlights.Click += BtnSearchFlights_Click;
            // 
            // DepartureDate
            // 
            DepartureDate.AutoSize = true;
            DepartureDate.Location = new Point(382, 19);
            DepartureDate.Name = "DepartureDate";
            DepartureDate.Size = new Size(86, 15);
            DepartureDate.TabIndex = 4;
            DepartureDate.Text = "Departure Date";
            // 
            // txtArrivalCity
            // 
            txtArrivalCity.Location = new Point(276, 15);
            txtArrivalCity.Name = "txtArrivalCity";
            txtArrivalCity.Size = new Size(100, 23);
            txtArrivalCity.TabIndex = 3;
            // 
            // ArrivalCity
            // 
            ArrivalCity.AutoSize = true;
            ArrivalCity.Location = new Point(205, 19);
            ArrivalCity.Name = "ArrivalCity";
            ArrivalCity.Size = new Size(65, 15);
            ArrivalCity.TabIndex = 2;
            ArrivalCity.Text = "Arrival City";
            // 
            // txtDepartureCity
            // 
            txtDepartureCity.Location = new Point(101, 16);
            txtDepartureCity.Name = "txtDepartureCity";
            txtDepartureCity.Size = new Size(100, 23);
            txtDepartureCity.TabIndex = 1;
            // 
            // DepartureCity
            // 
            DepartureCity.AutoSize = true;
            DepartureCity.Location = new Point(12, 19);
            DepartureCity.Name = "DepartureCity";
            DepartureCity.Size = new Size(83, 15);
            DepartureCity.TabIndex = 0;
            DepartureCity.Text = "Departure City";
            //DepartureCity.Click += label1_Click;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Location = new Point(12, 370);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(83, 39);
            btnAddBooking.TabIndex = 9;
            btnAddBooking.Text = "Book Item";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += BtnAddBooking_Click;
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.ItemHeight = 15;
            lstSearchResults.Location = new Point(12, 195);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new Size(776, 169);
            lstSearchResults.TabIndex = 7;
            // 
            // panelBookings
            // 
            panelBookings.Controls.Add(btnCancelBooking);
            panelBookings.Controls.Add(lstBookings);
            panelBookings.Location = new Point(0, 29);
            panelBookings.Name = "panelBookings";
            panelBookings.Size = new Size(800, 420);
            panelBookings.TabIndex = 1;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Location = new Point(3, 370);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(101, 39);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += BtnCancelBooking_Click;
            // 
            // lstBookings
            // 
            lstBookings.FormattingEnabled = true;
            lstBookings.ItemHeight = 15;
            lstBookings.Location = new Point(3, 0);
            lstBookings.Name = "lstBookings";
            lstBookings.Size = new Size(794, 364);
            lstBookings.TabIndex = 0;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(-1, 1);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(75, 23);
            btnBookings.TabIndex = 2;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += BtnBookings_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(80, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(161, 1);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(75, 23);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += BtnProfile_Click;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(txtPhoneNumber);
            panelLogin.Controls.Add(PhoneNumber);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(Email);
            panelLogin.Controls.Add(txtLastName);
            panelLogin.Controls.Add(LastName);
            panelLogin.Controls.Add(txtFirstName);
            panelLogin.Controls.Add(FirstName);
            panelLogin.Controls.Add(RegInfo);
            panelLogin.Controls.Add(btnRegister);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(Password);
            panelLogin.Controls.Add(txtUserName);
            panelLogin.Controls.Add(UserName);
            panelLogin.Location = new Point(0, 29);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(799, 419);
            panelLogin.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(83, 191);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(9, 194);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(54, 15);
            PhoneNumber.TabIndex = 13;
            PhoneNumber.Text = "Phone #:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.ScrollBars = ScrollBars.Vertical;
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(9, 165);
            Email.Name = "Email";
            Email.Size = new Size(39, 15);
            Email.TabIndex = 11;
            Email.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(83, 127);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            //txtLastName.TextChanged += textBox1_TextChanged;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(9, 130);
            LastName.Name = "LastName";
            LastName.Size = new Size(66, 15);
            LastName.TabIndex = 9;
            LastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(83, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 8;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(9, 101);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(67, 15);
            FirstName.TabIndex = 7;
            FirstName.Text = "First Name:";
            // 
            // RegInfo
            // 
            RegInfo.AutoSize = true;
            RegInfo.Location = new Point(9, 73);
            RegInfo.Name = "RegInfo";
            RegInfo.Size = new Size(186, 15);
            RegInfo.TabIndex = 6;
            RegInfo.Text = "If registering fill out the following:";
            //RegInfo.Click += RegInfo_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(207, 190);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(85, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(207, 11);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(85, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(86, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(12, 43);
            Password.Name = "Password";
            Password.Size = new Size(60, 15);
            Password.TabIndex = 2;
            Password.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(86, 11);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(12, 14);
            UserName.Name = "UserName";
            UserName.Size = new Size(68, 15);
            UserName.TabIndex = 0;
            UserName.Text = "User Name:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            cmbRoomType.Location = new Point(460, 17);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(121, 23);
            cmbRoomType.TabIndex = 17;
            //cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Location = new Point(382, 19);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(67, 15);
            RoomType.TabIndex = 18;
            RoomType.Text = "Room Type";
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(98, 49);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(200, 23);
            dtpCheckInDate.TabIndex = 19;
            // 
            // CheckinDate
            // 
            CheckinDate.AutoSize = true;
            CheckinDate.Location = new Point(9, 52);
            CheckinDate.Name = "CheckinDate";
            CheckinDate.Size = new Size(77, 15);
            CheckinDate.TabIndex = 20;
            CheckinDate.Text = "Checkin Date";
            // 
            // CheckoutDate
            // 
            CheckoutDate.AutoSize = true;
            CheckoutDate.Location = new Point(304, 52);
            CheckoutDate.Name = "CheckoutDate";
            CheckoutDate.Size = new Size(85, 15);
            CheckoutDate.TabIndex = 22;
            CheckoutDate.Text = "Checkout Date";
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(393, 49);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(200, 23);
            dtpCheckOutDate.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSearch);
            Controls.Add(panelLogin);
            Controls.Add(panelBookings);
            Controls.Add(btnProfile);
            Controls.Add(btnSearch);
            Controls.Add(btnBookings);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panelSearch.ResumeLayout(false);
            gbRestaurantSearch.ResumeLayout(false);
            gbRestaurantSearch.PerformLayout();
            gbHotelSearch.ResumeLayout(false);
            gbHotelSearch.PerformLayout();
            gbFlight.ResumeLayout(false);
            gbFlight.PerformLayout();
            panelBookings.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Panel panelBookings;
        private Button btnBookings;
        private Button btnSearch;
        private Button btnProfile;
        private Label DepartureCity;
        private ListBox lstSearchResults;
        private Button btnSearchFlights;
        private Label DepartureDate;
        private TextBox txtArrivalCity;
        private Label ArrivalCity;
        private TextBox txtDepartureCity;
        private DateTimePicker dtpDepartureDate;
        private Button btnAddBooking;
        private ListBox lstBookings;
        private Button btnCancelBooking;
        private Panel panelLogin;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label Password;
        private TextBox txtUserName;
        private Label UserName;
        private TextBox txtNumberOfGuests;
        private Label NumberOfGuests;
        private TextBox txtRestaurantCity;
        private Label RestaurantLocation;
        private Button btnSearchHotel;
        private TextBox txtNumberOfSleepers;
        private Label NumberofGuestshotel;
        private TextBox txtHotelCity;
        private Label HotelCity;
        private Button btnSearchRestaurant;
        private GroupBox gbFlight;
        private GroupBox gbRestaurantSearch;
        private GroupBox gbHotelSearch;
        private DateTimePicker dtpReservationDate;
        private Label ReservationDate;
        private Label RegInfo;
        private TextBox txtLastName;
        private Label LastName;
        private TextBox txtFirstName;
        private Label FirstName;
        private TextBox txtPhoneNumber;
        private Label PhoneNumber;
        private TextBox txtEmail;
        private Label Email;
        private ComboBox cmbRoomType;
        private Label RoomType;
        private Label CheckoutDate;
        private DateTimePicker dtpCheckOutDate;
        private Label CheckinDate;
        private DateTimePicker dtpCheckInDate;
    }
}
