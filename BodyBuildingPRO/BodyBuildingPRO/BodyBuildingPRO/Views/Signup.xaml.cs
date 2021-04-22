using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BodyBuildingPRO.Model;
using BodyBuildingPRO.Helpers;

namespace BodyBuildingPRO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signin : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public Signin()
        {
            InitializeComponent();
        }

        private async void Button_signup(object sender, EventArgs e)
        {
            FirebaseClient firebase = new FirebaseClient("https://bodybuilding-f3671-default-rtdb.firebaseio.com/");

            var person = await firebaseHelper.GetPerson(emaill.Text);

            if (person != null)
            {
                await DisplayAlert("Fail", "This username already exists", "OK");
                password1.Text = "";
                emaill.Text = "";
            }
            await firebase
                .Child("User")
                .PostAsync(new User() { Name = emaill.Text, Password = password1.Text });

        }
    }
}