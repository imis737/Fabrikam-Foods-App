using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fabrikam_Foods_App
{
    public partial class IntroPage : TabbedPage
    {

        public IntroPage()
        {
            InitializeComponent();

            mainLogoImage.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.Logomakr_3Pw6CZ.png");

            background.Source = ImageSource.FromResource("Fabrikam_Foods_App.Images.imageedit_1_5505383931.jpg");


        }
    }
}
