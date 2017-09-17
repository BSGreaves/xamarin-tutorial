using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class AppPropertiesStorage : ContentPage
    {

        void OnChange(object sender, System.EventArgs e)
        {
            var app = Application.Current as App;
            app.Title = title.Text;
			app.NotificationsEnabled  = notificationsEnabled.On;
            // This saves immediately. Useful for saving blocks of text that might get lost on sleep
            // Application.Current.SavePropertiesAsync();
		}

        public AppPropertiesStorage()
        {
            InitializeComponent();

			var app = Application.Current as App;

            title.Text = app.Title;
            notificationsEnabled.On = app.NotificationsEnabled;
		}
    }
}
