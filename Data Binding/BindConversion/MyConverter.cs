// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BindConversion
{
    public class MyConverter : IValueConverter
    {
        public object Convert(object o, Type type,
            object parameter, CultureInfo culture)
        {
            var date = (DateTime) o;//把o转成DateTime格式后，赋值给date。
            switch (type.Name)//当type的Name，
            {
                case "String"://为String时，
                    return date.ToString("F", culture);//返回
                case "Brush"://为Brush时，
                    return Brushes.Red;//刷成红色
                default:
                    return o;
            }
        }

        public object ConvertBack(object o, Type type,
            object parameter, CultureInfo culture) => null;
    }
}