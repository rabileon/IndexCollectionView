using IndexCollectionView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndexCollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexCollectionPage : ContentPage
    {
        public IndexCollectionPage()
        {
            InitializeComponent();
            BindingContext = new IndexCollectionViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as IndexCollectionViewModel).LoadItems();
        }
    }
}