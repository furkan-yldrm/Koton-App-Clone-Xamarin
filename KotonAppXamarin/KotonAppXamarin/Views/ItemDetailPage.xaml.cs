using KotonAppXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KotonAppXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}