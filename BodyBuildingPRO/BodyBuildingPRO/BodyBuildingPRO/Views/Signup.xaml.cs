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
            }

            if (ValidateEmailAndPassword() && person == null)
            {
                        await firebase
                            .Child("User")
                            .PostAsync(new User() { Name = emaill.Text, Password = password1.Text });
                            await DisplayAlert("Succes", "Registration succesfull", "OK");
                            await Navigation.PushAsync(new Login());
            }
         }


        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateEmailAndPassword()
        {
            bool IsValid = true;

            if (!IsValidEmail(emaill.Text))
            {
                DisplayAlert("Fail", "The email is invalid", "OK");
                password1.Text = "";
                password2.Text = "";
                emaill.Text = "";
                IsValid = false;
            }

            if (password1.Text != password2.Text)
            {
                DisplayAlert("Fail", "The password are not the same", "OK");
                password1.Text = "";
                password2.Text = "";
                emaill.Text = "";
                IsValid = false;
            }

            return IsValid;
        }
    }

}