using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class ToolbarItems : ContentPage
    {
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "Ok");
        }

        public ToolbarItems()
        {
            InitializeComponent();
        }
    }
}
