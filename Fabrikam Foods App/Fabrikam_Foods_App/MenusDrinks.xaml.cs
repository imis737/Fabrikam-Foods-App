using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class MenusDrinks : ContentPage
    {
        public MenusDrinks()
        {
            InitializeComponent();

            Martini.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.absolut_heel_spur_martini.png");
            Mojito.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.2.jpg");
            Negroni.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.dutch-negroni1.jpg");
            LongIslandIcedTea.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.Long-Island-Iced-Tea.jpg");

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManusDeserts());
        }
    }
}
