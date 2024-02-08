using Microsoft.Maui.Controls;

namespace SocialMediaProfileApp
{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent()
            BindingContext = new ProfileViewModel();
        }

        private async void EditButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Under Construction" , "This feature is not available yet.", "OK");
        }

    }
}