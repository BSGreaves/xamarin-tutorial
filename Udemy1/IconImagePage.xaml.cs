using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Udemy1
{
    public partial class IconImagePage : ContentPage
    {

        // All iOS specific images go in the iOS Resources folder
        // NB Best to user 3 different sizes for iOS files
        public IconImagePage()
        {
            InitializeComponent();
            // Following doesn't work...
            //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //iOS: "camIcon.png"));

            //Trying this
            //btn = UIButton.FromType(UIButtonType.System);
            //buttonRect.SetImage(UIImage.FromFile("star-gold45.png"), UIControlState.Normal);
            //}
        }
    }
}
