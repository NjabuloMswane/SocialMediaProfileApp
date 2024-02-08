using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace SocialMediaProfileApp

{
    public class ProfileViewModel : INOTIFYPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ProfilePicture { get; set;} //This could be URL or Local path to the image
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public string Bio {get; set;}
        public string Interest {get; set;}

        public ProfileViewModel()
        {
            //Initialize profile data
            ProfilePicture = "profile_image_url_or_path";
            FirstName = "Njabulo"; //Example firstname
            LastName = "Mswane"; //Example last name
            Bio = "I am .Net Developer";
            Interest ="Technology, Reading, Travelling", 
        }
    }
}