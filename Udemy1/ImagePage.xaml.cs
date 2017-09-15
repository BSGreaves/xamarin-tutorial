using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Udemy1
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
             
            // How to set image source with a url
            // image.Source = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            // There's also caching you can manipulate...
            // 3 Types of aspects... aspectFit (def), aspectfill, and fill
            // Aspect fill will zoom in horizontally and maintain the top-bottom ratio. Won't stretch the image.

            // Image that's embedded using a codebehind
            // Remember to set the image build action to embedded resource!!!
            image.Source = ImageSource.FromResource("Udemy1.Images.wizard.jpg");
            // Format is AppName.FolderName.ImageName.ext

        }
    }
}
