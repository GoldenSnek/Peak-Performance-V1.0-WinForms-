using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peak_Performance_V1._0
{
    internal interface IHome
    {
        void LoadUsers(); //load the highest rated users
        void LoadVehicles(); //load the highest rated vehicles
        void OpenChildForm(Form childForm); //MAIN method for switching between forms
    }
    internal interface IViewAllVehicles
    {
        void LoadVehicles(string? filterQuery = null); //load ALL the vehicles from the database
        void Card_RentClicked(int vehicleID); //rent the vehicle
        void Card_FullDetailsClicked(int vehicleID); //view the full details of the vehicle
    }
    internal interface IClientViewRental
    {
        int VehicleID { get; set; }
        int OwnerID { get; set; }
        int UserRating { get; set; }
        int VehicleRating { get; set; }
        bool CurrentRent { get; set; }
        void LoadDetails(); //load rental details for the client
        void btnRate_Click(object sender, EventArgs e); //handle rating submission
    }
    internal interface IProviderViewRental
    {
        void LoadVehicles(); //load waiting for approval and currently being rented the vehicles from the database
        void Card_FullDetailsClickedRent(int vehicleID);
        void Card_ApproveClicked(int vehicleID);
        void Card_FinishRentalClicked(int vehicleID);
    }
    internal interface IProviderAddVehicle
    {
        void LoadVehicles();
        void btnAddVehicle_Click(object sender, EventArgs e);
        void Card_FullDetailsClicked(int vehicleID);
    }
    internal interface IProviderUpdateVehicle
    {
        void LoadVehicles();
        void btnUpdate_Click(object sender, EventArgs e);
        void btnDelete_Click(object sender, EventArgs e);
        void Card_EditClicked(int vehicleID, string generalType, string specificType, string make, string model, int? vehicleYear, string transmission, string drivetrain,
                                    string licensePlate, string color, string fuelType, int? seats, double? mileage, double? priceDaily, double? priceHourly, Image vehicleImage);
        void Card_FullDetailsClicked(int vehicleID);
    }
    internal interface IManageAccount
    {
        void btnSave_Click(object sender, EventArgs e);
        void btnDelete_Click(object sender, EventArgs e);
    }
    internal interface IFullVehicleDetails
    {
        string? GeneralType { get; set; }
        string? SpecificType { get; set; }
        string? Make { get; set; }
        string? Model { get; set; }
        int VehicleYear { get; set; }
        string? Transmission { get; set; }
        string? Drivetrain { get; set; }
        string? LicensePlate { get; set; }
        string? VehicleColor { get; set; }
        string? FuelType { get; set; }
        int Seats { get; set; }
        double Mileage { get; set; }
        double PriceDaily { get; set; }
        double PriceHourly { get; set; }
        Image VehicleImage { get; set; }

        string? Username { get; set; }
        string? FullName { get; set; }
        string? Address { get; set; }
        string? Birthday { get; set; }
        string? Email { get; set; }
        int DriversLicenseID { get; set; }
        int ContactNumber { get; set; }
        double UserRating { get; set; }
        Image ProfilePicture { get; set; }

        string? RentType { get; set; }
        int Duration { get; set; }
        string? PaymentType { get; set; }
        string? ChildSeat { get; set; }
        string? SoundSystem { get; set; }
        string? Powerbank { get; set; }
        string? WiFi { get; set; }
        string? Notes { get; set; }
        double TotalPrice { get; set; }
        double VehicleRating { get; set; }
    }
    internal interface IRentVehicle
    {
        void LoadVehicleDetails();
        void btnFinalize_Click(object sender, EventArgs e);
    }
    internal interface IAdminAllUsers
    {
        void LoadData();
        void btnRemove_Click(object sender, EventArgs e);
    }
    internal interface IAdminAllVehicles
    {
        void LoadData();
        void btnRemove_Click(object sender, EventArgs e);
    }
}