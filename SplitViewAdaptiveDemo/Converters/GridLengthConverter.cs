using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SplitViewAdaptiveDemo.Converters {
    class GridLengthConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value is double) {
                return new GridLength((double)value);
            } else throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
