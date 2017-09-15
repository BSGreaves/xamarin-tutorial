using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            // Creates the page. Must go first! 
            InitializeComponent();

            slider.Value = 0.5;


            // How to add platform specific code
            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }

        }
        // How to write event handler
        //void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    sliderLabel.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
} 
