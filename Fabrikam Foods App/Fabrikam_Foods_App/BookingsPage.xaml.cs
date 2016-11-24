using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class BookingsPage : ContentPage
    {
        public BookingsPage()
        {
            InitializeComponent();

            background.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.imageedit_1_4307878177.png");
              
        }

        async public void Button_Clicked(object sender, EventArgs e)
        {
            //AzureDataService azureService = new AzureDataService();
            string name1 = name.Text;
            string email1 = email.Text;
            int phone1 = Convert.ToInt32(phone.Text);

            DateTime date1 = date.Date;
            TimeSpan time1 = time.Time;

            Bookings booki = new Bookings()
            {
                Name = name1,
                Email = email1,
                Number = phone1,
                Date = date1,
                Time = time1

            };

            await AzureManager.AzureManagerInstance.AddBooking(booki);

            await DisplayAlert("Saved!", "Your booking has been saved! If you'd like to edit it, you can see your bookings by selecting the button below, and then selecting edit.", "OK");


        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookingsDisplayPage());
        }
    }
}
