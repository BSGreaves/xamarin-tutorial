using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class TablePage : ContentPage
    {
        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
                
            Navigation.PushAsync(page);
        }

        public TablePage()
        {
            InitializeComponent();
        }
    }
}
