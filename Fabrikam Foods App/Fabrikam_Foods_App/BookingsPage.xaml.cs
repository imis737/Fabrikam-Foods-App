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
            AzureDataService azureService = new AzureDataService();
            string name1 = name.Text;
            string email1 = email.Text;
            int phone1 = Convert.ToInt32(phone.Text);

            DateTime date1 = date.Date;
            TimeSpan time1 = time.Time;

            await azureService.AddBooking(name1, email1, phone1, date1, time1);


        }
    }
}
