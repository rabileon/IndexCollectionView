using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace IndexCollectionView.Converters
{
    public class CollectionViewToIndex : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                CollectionView collectionView = (CollectionView)parameter; // Identificamos el Collection View
                IList collection = (IList)collectionView.ItemsSource; // Lo asignamos a un Enumerable

                return collection.IndexOf(value) + 1; // Obtemos el index, le sumamos 1 para devolver el index apartir de 1 y retornamos el valor.
            }
            catch (Exception e)
            {
                return -1; // En caso de ser erroneo devolveremos el valor como -1.
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
