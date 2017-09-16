using System;
using System.Collections.Generic;
using Udemy1.Models;
using Xamarin.Forms;

namespace Udemy1
{
    public partial class MasterDetailChild : ContentPage
    {
        public MasterDetailChild(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException();
            }

            BindingContext = contact;

            InitializeComponent();
        }
    }
}
