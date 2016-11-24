using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class BookingsDisplayPage : ContentPage
    {
        public BookingsDisplayPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            List<Bookings> bookings = await AzureManager.AzureManagerInstance.GetBookings();

            BookingsList.ItemsSource = bookings;
        }

        async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var booking = (sender as MenuItem).CommandParameter as Bookings;

            await Navigation.PushModalAsync(new BookingsUpdatePage(booking));
        }

        async void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            var booking = (sender as MenuItem).CommandParameter as Bookings;

            await AzureManager.AzureManagerInstance.DeleteBooking(booking);

            List<Bookings> bookings = await AzureManager.AzureManagerInstance.GetBookings();

            BookingsList.ItemsSource = bookings;
        }
    }
}
