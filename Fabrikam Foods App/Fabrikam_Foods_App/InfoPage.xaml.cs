using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();

            entrance.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.Georges_Hotel_Istanbul_Boutique_Hotel-Hotel_Entrance_and_Restaurant.jpg");
        }
    }
}
