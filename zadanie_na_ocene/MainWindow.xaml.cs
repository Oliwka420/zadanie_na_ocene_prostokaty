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

namespace zadanie_na_ocene
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scroll_paprotka.Height = paproc_kwadrat.Height;
            Canvas.SetLeft(scroll_paprotka, Canvas.GetLeft(paproc_kwadrat));
            Canvas.SetTop(scroll_paprotka, Canvas.GetTop(paproc_kwadrat));

            Canvas.SetLeft(scroll_brzoza, Canvas.GetLeft(brzoza_kwadrat));
            Canvas.SetTop(scroll_brzoza, Canvas.GetTop(brzoza_kwadrat));

            Canvas.SetLeft(scroll_narcyz, Canvas.GetLeft(narcyz_kwadrat));
            Canvas.SetTop(scroll_narcyz, Canvas.GetTop(narcyz_kwadrat));

            Canvas.SetLeft(scroll_bambus, Canvas.GetLeft(bambus_kwadrat));
            Canvas.SetTop(scroll_bambus, Canvas.GetTop(bambus_kwadrat));

            Canvas.SetLeft(scroll_aloes, Canvas.GetLeft(aloes_kwadrat));
            Canvas.SetTop(scroll_aloes, Canvas.GetTop(aloes_kwadrat));

            Canvas.SetLeft(scroll_irys, Canvas.GetLeft(irys_kwadrat));
            Canvas.SetTop(scroll_irys, Canvas.GetTop(irys_kwadrat));

        }
        private void paprotka(object sender, RoutedEventArgs e)
        {

        }

        private void paprotka2(object sender, RoutedEventArgs e)
        {

        }
    }
}
