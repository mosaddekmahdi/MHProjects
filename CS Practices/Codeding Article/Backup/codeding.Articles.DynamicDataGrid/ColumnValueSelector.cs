//ColumnValueSelector.cs

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;

namespace codeding.Articles.DynamicDataGrid
{
    public class ColumnValueSelector : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            StringRow row = (StringRow)value;
            string columnName = (string)parameter;
            return (row[columnName]);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
