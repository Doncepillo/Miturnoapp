using System;

using Xamarin.Forms;

namespace MasterDetail.Services
{
    public class Service : ContentPage
    {
        public Service()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

