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
        private async void Button_180(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FreeBack());
        }
    }
}