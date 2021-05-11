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
    public partial class FreeBack : ContentPage
    {
        public FreeBack()
        {
            InitializeComponent();
        }

        private async void Button_Rotate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FreeFront());
        }

        private async void Button_Traps(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrapsExercises());
        }

        private async void Button_Triceps(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TricepsExercises());
        }

        private async void Button_Hamstrings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HamstringsExercises());
        }

        private async void Button_Calves(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalvesExercises());
        }

        private async void Button_Lats(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LatsExercises());
        }

        private async void Button_Lower(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LowerExercises());
        }

        private async void Button_Glutes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlutesExercises());
        }
    }
}