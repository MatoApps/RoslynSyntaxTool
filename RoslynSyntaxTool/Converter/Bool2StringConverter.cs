﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Workshop.Converter
{
    public class Bool2StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (string.IsNullOrEmpty((string)parameter))
            {
                parameter = "是|否";
            }
            var str1 = (parameter as string).Split('|')[0];
            var str2 = (parameter as string).Split('|')[1];

            return (bool)value ? str1 : str2;



        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
