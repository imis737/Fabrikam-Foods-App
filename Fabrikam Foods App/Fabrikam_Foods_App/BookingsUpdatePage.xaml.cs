using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class BookingsUpdatePage : ContentPage
    {
        private static Bookings bookingtoChange;
        public BookingsUpdatePage(Bookings booking)
        {
            InitializeComponent();

            bookingtoChange = booking;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            string name1 = name.Text;
            string email1 = email.Text;
            int phone1 = Convert.ToInt32(phone.Text);

            DateTime date1 = date.Date;
            TimeSpan time1 = time.Time;

            Bookings booki = new Bookings()
            {
                ID = bookingtoChange.ID,
                Name = name1,
                Email = email1,
                Number = phone1,
                Date = date1,
                Time = time1

            };

            await AzureManager.AzureManagerInstance.UpdateBooking(booki);

            await DisplayAlert("Saved!", "Your booking has been successfully updated.", "OK");

            await Navigation.PopModalAsync();
        }
    }
}
