﻿using System;
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
        }

        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new MainPage());
        //}
    }
}
