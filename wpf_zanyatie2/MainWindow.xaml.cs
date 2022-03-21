﻿using ClassLibrary1;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_zanyatie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            if (double.TryParse(this.TextBoxA.Text, out a) && double.TryParse(this.TextBoxB.Text, out b) && double.TryParse(this.TextBoxC.Text, out c))
            {
                double d, x1, x2;
                string message;
                KU.KvadrUr(a, b, c, out d, out x1, out x2, out message);
                string result = "";
                if (!double.IsNaN(d)) result += $"D={d}\n";
                if (!double.IsNaN(x1)) result += $"X1={x1}\n";
                if (!double.IsNaN(x2)) result += $"X2={x2}\n";
                if (!string.IsNullOrEmpty(message)) result += message;
                this.result.Content = result;
            }
        }

        private void TextBoxA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
