using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class HeirarchicalNavigation : ContentPage
    {

		// in App.xaml.cs, had to add MainPage = new NavigationPage(new HeirarchicalNavigation());
		async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionHeirPage());
            // Another option? Maybe for save or delete photo??
			//await Navigation.PushAsync(new IntroductionHeirPage());

		}

        public HeirarchicalNavigation()
        {
            InitializeComponent();
        }
    }
}
