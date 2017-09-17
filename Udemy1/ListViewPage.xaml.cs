using System;
using System.Collections.Generic;
using System.Linq;
using Udemy1.Models;
using Xamarin.Forms;

namespace Udemy1
{
    public partial class ListViewPage : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
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

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageURL = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageURL = "http://lorempixel.com/100/100/people/2", Status = "Sup" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }

            return contacts.Where(c => c.Name.StartsWith(searchText));
		}

        public ListViewPage()
        {
            InitializeComponent();

            listView.ItemsSource = GetContacts();

			//var names = new List<string>
			//{ 
			//    "Bob",
			//    "John",
			//    "Bill"          
			//};

			//listView.ItemsSource = names;

			//listView.ItemsSource = new List<Contact>
			//{
			//    new Contact { Name = "Mosh", ImageURL = "http://lorempixel.com/100/100/people/1" },
			//    new Contact { Name = "John", ImageURL = "http://lorempixel.com/100/100/people/2", Status = "Sup" },
			//};

			


		}
    }
}
