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
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categories2());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categories3());
        }
    }
}