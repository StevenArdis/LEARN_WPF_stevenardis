// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace BindConversion
{
    public class MyData : INotifyPropertyChanged
    {
        private DateTime _thedate;//定义一个datetime型字段，私有

        public MyData()//定义字段_thedate构造方法，等于当前时间
        {
            _thedate = DateTime.Now;
        }

        public DateTime TheDate
        {
            get { return _thedate; }
            set
            {
                _thedate = value;
                OnPropertyChanged("TheDate");//****重点：这个在xaml绑定这个属性的时候
            }
        }

        // Declare event
        public event PropertyChangedEventHandler PropertyChanged;
        // OnPropertyChanged method to update property value in binding
        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}