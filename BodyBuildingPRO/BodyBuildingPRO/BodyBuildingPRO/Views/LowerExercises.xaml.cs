﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BodyBuildingPRO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LowerExercises : ContentPage
    {
        public LowerExercises()
        {
            InitializeComponent();
        }
        private async void Button_Favourites(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}