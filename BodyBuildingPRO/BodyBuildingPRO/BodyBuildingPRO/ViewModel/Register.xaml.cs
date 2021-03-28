using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using BodyBuildingPRO.Models;

namespace BodyBuildingPRO.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {   
                UserEmail = EntryUserEmail.Text,
                UserName = EntryUserName.Text,
                UserPassword = EntryUserPassword.Text,
                UserPhoneNumber = EntryUserPhoneNumber.Text
        };
            using(SQLiteConnection connection = new SQLiteConnection(App.FilePath))
            {
                connection.CreateTable<User>();
                int rowsAdded = connection.Insert(user);
            }
           
        }
    }
}