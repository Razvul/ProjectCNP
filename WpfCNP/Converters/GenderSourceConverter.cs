using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using CommonCNP;

namespace WpfCNP.Converters
{
    class GenderSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var a = Enum.GetValues(typeof(Enums.Sex));


            ObservableCollection<string> temp = new ObservableCollection<string>();


            temp.Add("test1");
            temp.Add("test2");
            return temp;

            return value == null ? null : Enum.GetValues(typeof(Enums.Sex));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
