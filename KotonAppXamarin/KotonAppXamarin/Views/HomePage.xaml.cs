using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KotonAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public class ImageInformation
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
        }
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            ImageCollection = new ObservableCollection<ImageInformation>()
            {
                new ImageInformation{_Image ="campaign.png"},
                new ImageInformation{_Image ="campaign2.png"},
                new ImageInformation{_Image ="campaign3.png"},
                new ImageInformation{_Image ="campaign4.png"},
            };
        }
        public class Product
        {
            public string Description { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }
        }
        public List<Product> Collection { get => ProductList(); }
        private List<Product> ProductList()
        {
            var item = new List<Product>();
            item.Add(new Product { Description = "Basic Tişört Pamuklu", Image = "basictshirt.png", Price = "84.99₺" });
            item.Add(new Product { Description = "Chino Pantolon", Image = "pants.png", Price = "76.00₺" });
            item.Add(new Product { Description = "İşleme Detaylı Gömlek", Image = "islemedetay.png", Price = "104.99₺" });
            item.Add(new Product { Description = "Kot Ceket Pamuklu", Image = "jeanjacket.png", Price = "289.99₺" });
            item.Add(new Product { Description = "Oversize Baskılı Tişört", Image = "oversize2.png", Price = "99.99₺" });
            item.Add(new Product { Description = "Mars Baskılı Tişört", Image = "mars.png", Price = "39.99₺" });
            item.Add(new Product { Description = "Fırfırlı Rahat Kesim Elbise", Image = "cloth1.jpeg", Price = "219.99₺" });
            item.Add(new Product { Description = "Oversize Tişört", Image = "oversize3.png", Price = "104.99₺" });
            item.Add(new Product { Description = "Kadın Çorap", Image = "socks.png", Price = "24.99₺" });
            return item;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetails());
        }

    }
}