using IndexCollectionView.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace IndexCollectionView.ViewModels
{
    public class IndexCollectionViewModel : BaseViewModel
    {
        private ObservableCollection<Item> items;

        public ObservableCollection<Item> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public IndexCollectionViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        public async Task LoadItems()
        {
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }
    }
}