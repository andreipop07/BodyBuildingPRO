using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BodyBuildingPRO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FreeFront : ContentPage
    {
        public FreeFront()
        {
            InitializeComponent();
        }
        private async void Button_Rotate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FreeBack());
        }

        private async void Button_Abs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsExercises());
        }

        private async void Button_Chest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChestExercises());
        }

        private async void Button_Abductors(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbductorsExercises());
        }

        private async void Button_Adductors(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdductorsExercises());
        }

        private async void Button_Shoulders(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShouldersExercises());
        }

        private async void Button_Biceps(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BicepsExercises());
        }

        private async void Button_Forearms(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForearmsExercises());
        }

        private async void Button_Obliques(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObliquesExercises());
        }

        private async void Button_Quads(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuadsExercises());
        }
    }
}