using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KotonAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bag : ContentPage
    {
        public Bag()
        {
            InitializeComponent();
        }
        private async void GotoFav(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Favorites());
        }

        private async void goHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}