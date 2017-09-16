using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Udemy1.Models;
using Xamarin.Forms;

namespace Udemy1
{
    public partial class ListViewWithContext : ContentPage
    {
        //Currently breaking
        //Observable collection watches the field and updates other things that rely on it if it changes!
        private ObservableCollection<Contact> _contacts;

		void Call_Clicked(object sender, System.EventArgs e)
		{
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

		void Delete_Clicked(object sender, System.EventArgs e)
		{
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);

		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "OK");
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			//var contact = e.Item as Contact;
			//DisplayAlert("Tapped", contact.Name, "OK");
		}


        public ListViewWithContext()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
			{
				new Contact { Name = "Mosh", ImageURL = "http://lorempixel.com/100/100/people/1" },
				new Contact { Name = "John", ImageURL = "http://lorempixel.com/100/100/people/2", Status = "Sup" },
			};

            listView.ItemsSource = _contacts;
        }
    }
}
