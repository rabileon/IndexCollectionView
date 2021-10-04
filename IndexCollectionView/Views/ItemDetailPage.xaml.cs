using IndexCollectionView.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IndexCollectionView.Views
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