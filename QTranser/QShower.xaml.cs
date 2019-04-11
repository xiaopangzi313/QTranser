﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace QTranser
{
    /// <summary>
    /// QShowse.xaml 的交互逻辑
    /// </summary>
    public partial class QShower : Window
    {
        public QShower()
        {
            InitializeComponent();
            DataContext = QTranse.Mvvm;
            this.Height = SystemParameters.WorkArea.Height / 2;
        }

        public void Window_Deactivated(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private bool IsTop { get; set; } = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //后台代码动态修改控件模板属性 参考链接：https://www.itsvse.com/thread-2740-1-1.html
            Border border = (Border)((Button)sender).Template.FindName("Border", (Button)sender);
            if (IsTop)
            {
                border.Background = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
                this.Deactivated -= Window_Deactivated;
                IsTop = false;
            }
            else
            {
                border.Background = Brushes.Transparent;
                this.Deactivated += Window_Deactivated;
                IsTop = true;
            }


          
        }
    }
}