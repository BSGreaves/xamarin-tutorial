using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Udemy1
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class EntryPage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

		public IList<ContactMethod> GetContactMethods()
		{
			return new List<ContactMethod>
		    {
			    new ContactMethod {Id = 1, Name = "SMS"},
			    new ContactMethod {Id = 2, Name = "Email"}
		    };
		}

        //void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        //{
        //    // Bonds or does something when text is changed.
        //    label2.Text = e.NewTextValue;
        //}

        //void Handle_Completed(object sender, System.EventArgs e)
        //{
        //    // So the label shows when the user hits return on the password
        //    label.Text = "Completed";
        //}

        public EntryPage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in GetContactMethods())
            {
                picker.Items.Add(method.Name);
            }
        }
    }
}
