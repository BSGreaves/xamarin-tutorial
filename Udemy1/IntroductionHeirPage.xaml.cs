using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class IntroductionHeirPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
            //Another option
			//await Navigation.PopModalAsync();

		}

        public IntroductionHeirPage()
        {
            InitializeComponent();
        }
    }
}
