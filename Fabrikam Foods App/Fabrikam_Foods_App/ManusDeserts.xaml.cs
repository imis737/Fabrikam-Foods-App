using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class ManusDeserts : ContentPage
    {
        public ManusDeserts()
        {
            InitializeComponent();

            cheese.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.r_DSC_0496.jpg");
            chocOysters.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.hotel-chocolat-oysters-and-champagne.jpg");
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
