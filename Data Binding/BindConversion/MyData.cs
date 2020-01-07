// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace BindConversion
{
    /// <summary>
    /// ��δ����׼д����ͨ��INotifyPropertyChanged�ӿڣ�֪ͨ�������Ա��
    /// </summary>
    public class MyData : INotifyPropertyChanged
    {
        private DateTime _thedate;//����һ��datetime���ֶΣ�˽��

        public MyData()//�����ֶ�_thedate���췽�������ڵ�ǰʱ��
        {
            _thedate = DateTime.Now;
        }

        public DateTime TheDate
        {
            get { return _thedate; }
            set
            {
                _thedate = value;
                OnPropertyChanged("TheDate");//****�ص㣺�����xaml��������Ե�ʱ��
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