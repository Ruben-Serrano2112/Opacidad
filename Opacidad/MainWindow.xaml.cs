using System.Windows;


namespace Opacidad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Puntero_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
           
           if(sender == Episodio4)
            {
                Episodio4.Opacity = 1;
            }
           else if(sender == Episodio5)
            {
                Episodio5.Opacity = 1;
            }
           else
            {
                Episodio6.Opacity = 1;
            }
            
            
        }
        private void Puntero_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Episodio4.Opacity = 0.5;
            Episodio5.Opacity = 0.5;
            Episodio6.Opacity = 0.5;
        }

    }
}
