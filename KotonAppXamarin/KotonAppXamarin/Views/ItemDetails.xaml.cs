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
    public partial class ItemDetails : ContentPage
    {
        /* public class ImageInformation
         {
             public ImageSource _Image { get; set; }
         }
         private ObservableCollection<ImageInformation> imageCollection;

         public ObservableCollection<ImageInformation> ImageCollection
         {
             get { return imageCollection; }
             set
             {
                 imageCollection = value;
                 OnPropertyChanged();
             }
         }*/
        public ItemDetails()
        {
            InitializeComponent();
            BindingContext = this;

        }
        public class Detay
        {
            public string Image { get; set; }
            public string Aciklama { get; set; }
        }
        public List<Detay> Collection { get => ProductList(); }

        private List<Detay> ProductList()
        {
            var item = new List<Detay>();
            item.Add(new Detay { Image = "detailUrun1.png", Aciklama = "REGULAR FIT, BASIC TİŞÖRT" });
            return item;
        }
    }
}