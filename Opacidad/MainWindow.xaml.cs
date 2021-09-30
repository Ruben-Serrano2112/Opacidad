using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace Opacidad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Puntero_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Episodio4.Opacity = 1;
            Episodio5.Opacity = 1;
            Episodio6.Opacity = 1;
        }
    }
}
