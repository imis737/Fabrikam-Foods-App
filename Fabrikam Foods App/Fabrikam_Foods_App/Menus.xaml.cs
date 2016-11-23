using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class Menus : ContentPage
    {
        public Menus()
        {
            InitializeComponent();

            burger.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.heroburgers.jpg");
            pizza.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.pizza.jpg");
            fish.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.miso-salmon-3-of-4.jpg");
            curry.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.curry.jpg");
            spag.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.Spaghetti_Bolognese1.jpg");
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenusDrinks());
        }
    }
}
