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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Nueva.xaml
    /// </summary>
    public partial class Nueva : Window
    {
        NuevaVM vm;
        public Nueva()
        {
            InitializeComponent();
            vm = new NuevaVM();
        }

        private void Aceptar_CLick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}