using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Fabrikam_Foods_App
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(47.6698814, -122.1565974), Distance.FromMiles(1)));


            var position = new Position(47.6698814, -122.1565974);

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Here we are!",
                Address = "Come and say hello!"
            };

            MyMap.Pins.Add(pin);

        }
    }
}
