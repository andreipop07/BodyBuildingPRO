using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Database;
using Firebase.Database.Query;
using BodyBuildingPRO.Model;
using BodyBuildingPRO.Helpers;

namespace BodyBuildingPRO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        
        public Login()
        {
            InitializeComponent();
        }

        
        private async void Button_Signin(object sender, EventArgs e)
        {

            var person = await firebaseHelper.GetPerson(email.Text);
            if (person != null && person.Password == password.Text)
            {
                await Navigation.PushAsync(new Home());
                //await DisplayAlert("Success", "Person Retrive Successfully", "OK");

            }
            else
            {
                await DisplayAlert("Fail", "Invalid username or password", "OK");
                password.Text = "";
                email.Text = "";
            }
        }

        private async void Button_Register(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signin());
        }

        private async void Button_Forgot(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }
    }
}