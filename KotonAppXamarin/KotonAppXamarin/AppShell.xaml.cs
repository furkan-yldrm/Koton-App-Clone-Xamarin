using KotonAppXamarin.ViewModels;
using KotonAppXamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KotonAppXamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(Bag), typeof(Bag));
        }

    }
}
