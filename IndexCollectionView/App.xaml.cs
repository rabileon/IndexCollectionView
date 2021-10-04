using IndexCollectionView.Services;
using IndexCollectionView.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndexCollectionView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Views.IndexCollectionPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
