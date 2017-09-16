using System;
using System.Collections.Generic;
using Udemy1.Models;
using Xamarin.Forms;

namespace Udemy1
{
    public partial class MasterDetail : ContentPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var contact = e.SelectedItem as Contact;
            Navigation.PushAsync(new MasterDetailChild(contact));
            listView.SelectedItem = null;
        }

        public MasterDetail()
        {
            InitializeComponent();

			listView.ItemsSource = new List<Contact>
			{
			    new Contact { Name = "Mosh", ImageURL = "http://lorempixel.com/100/100/people/1" },
			    new Contact { Name = "John", ImageURL = "http://lorempixel.com/100/100/people/2", Status = "Sup" },
			};

		}
    }
}
