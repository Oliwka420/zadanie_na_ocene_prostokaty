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
            slider_paprotka.Width = paproc_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_paprotka, Canvas.GetLeft(paproc_kwadrat));
            Canvas.SetTop(scroll_paprotka, Canvas.GetTop(paproc_kwadrat));
            Canvas.SetLeft(slider_paprotka, Canvas.GetLeft(paproc_kwadrat)+20);
            Canvas.SetTop(slider_paprotka, Canvas.GetTop(paproc_kwadrat));

            scroll_brzoza.Height = brzoza_kwadrat.Height;
            slider_brzoza.Width = brzoza_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_brzoza, Canvas.GetLeft(brzoza_kwadrat));
            Canvas.SetTop(scroll_brzoza, Canvas.GetTop(brzoza_kwadrat));
            Canvas.SetLeft(slider_brzoza, Canvas.GetLeft(brzoza_kwadrat)+20);
            Canvas.SetTop(slider_brzoza, Canvas.GetTop(brzoza_kwadrat));

            scroll_narcyz.Height = narcyz_kwadrat.Height;
            slider_narcyz.Width = narcyz_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_narcyz, Canvas.GetLeft(narcyz_kwadrat));
            Canvas.SetTop(scroll_narcyz, Canvas.GetTop(narcyz_kwadrat));
            Canvas.SetLeft(slider_narcyz, Canvas.GetLeft(narcyz_kwadrat) + 20);
            Canvas.SetTop(slider_narcyz, Canvas.GetTop(narcyz_kwadrat));

            scroll_bambus.Height = bambus_kwadrat.Height;
            slider_bambus.Width = bambus_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_bambus, Canvas.GetLeft(bambus_kwadrat));
            Canvas.SetTop(scroll_bambus, Canvas.GetTop(bambus_kwadrat));
            Canvas.SetLeft(slider_bambus, Canvas.GetLeft(bambus_kwadrat) + 20);
            Canvas.SetTop(slider_bambus, Canvas.GetTop(bambus_kwadrat));

            scroll_aloes.Height = aloes_kwadrat.Height;
            slider_aloes.Width = aloes_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_aloes, Canvas.GetLeft(aloes_kwadrat));
            Canvas.SetTop(scroll_aloes, Canvas.GetTop(aloes_kwadrat));
            Canvas.SetLeft(slider_aloes, Canvas.GetLeft(aloes_kwadrat) + 20);
            Canvas.SetTop(slider_aloes, Canvas.GetTop(aloes_kwadrat));

            scroll_irys.Height = irys_kwadrat.Height;
            slider_irys.Width = irys_kwadrat.Width - 20;
            Canvas.SetLeft(scroll_irys, Canvas.GetLeft(irys_kwadrat));
            Canvas.SetTop(scroll_irys, Canvas.GetTop(irys_kwadrat));
            Canvas.SetLeft(slider_irys, Canvas.GetLeft(irys_kwadrat) + 20);
            Canvas.SetTop(slider_irys, Canvas.GetTop(irys_kwadrat));

        }

        public void odkrywanie(Rectangle kwadrat, Slider slider)
        {
            kwadrat.Visibility = Visibility.Visible;
            slider.Visibility = Visibility.Visible;
        }
        public void zakrywanie(Rectangle kwadrat, Slider slider)
        {
            kwadrat.Visibility = Visibility.Hidden;
            slider.Visibility = Visibility.Hidden;
        }
        private void paprotka(object sender, RoutedEventArgs e)
        {
            odkrywanie(paproc_kwadrat, slider_paprotka);
            scroll_paprotka.Visibility = Visibility.Visible;
        }

        private void paprotka2(object sender, RoutedEventArgs e)
        {
            zakrywanie(paproc_kwadrat, slider_paprotka);
            scroll_paprotka.Visibility = Visibility.Hidden;
        }
        private void brzoza(object sender, RoutedEventArgs e)
        {
            odkrywanie(brzoza_kwadrat, slider_brzoza);
            scroll_brzoza.Visibility = Visibility.Visible;
        }

        private void brzoza2(object sender, RoutedEventArgs e)
        {
            zakrywanie(brzoza_kwadrat, slider_brzoza);
            scroll_brzoza.Visibility = Visibility.Hidden;
        }
        private void Narcyz(object sender, RoutedEventArgs e)
        {
            odkrywanie(narcyz_kwadrat, slider_narcyz);
            scroll_narcyz.Visibility = Visibility.Visible;
        }

        private void Narcyz2(object sender, RoutedEventArgs e)
        {
            zakrywanie(narcyz_kwadrat, slider_narcyz);
            scroll_narcyz.Visibility = Visibility.Hidden;
        }
        private void Bambus(object sender, RoutedEventArgs e)
        {
            odkrywanie(bambus_kwadrat, slider_bambus);
            scroll_bambus.Visibility = Visibility.Visible;
        }

        private void Bambus2(object sender, RoutedEventArgs e)
        {
            zakrywanie(bambus_kwadrat, slider_bambus);
            scroll_bambus.Visibility = Visibility.Hidden;
        }
        private void Aloes(object sender, RoutedEventArgs e)
        {
            odkrywanie(aloes_kwadrat, slider_aloes);
            scroll_aloes.Visibility = Visibility.Visible;
        }

        private void Aloes2(object sender, RoutedEventArgs e)
        {
            zakrywanie(aloes_kwadrat, slider_aloes);
            scroll_aloes.Visibility = Visibility.Hidden;
        }

        private void Irys(object sender, RoutedEventArgs e)
        {
            odkrywanie(irys_kwadrat, slider_irys);
            scroll_irys.Visibility = Visibility.Visible;
        }

        private void Irys2(object sender, RoutedEventArgs e)
        {
            zakrywanie(irys_kwadrat, slider_irys);
            scroll_irys.Visibility = Visibility.Hidden;
        }

        private void scroll_irys_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            irys_kwadrat.Height = scroll_irys.Value;
        }

        private void scroll_aloes_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            aloes_kwadrat.Height = scroll_aloes.Value;
        }

        private void scroll_bambus_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            bambus_kwadrat.Height = scroll_bambus.Value;
        }

        private void scroll_narcyz_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            narcyz_kwadrat.Height = scroll_narcyz.Value;
        }

        private void scroll_brzoza_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            brzoza_kwadrat.Height = scroll_brzoza.Value;
        }

        private void scroll_paprotka_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            paproc_kwadrat.Height = scroll_paprotka.Value;
        }

        private void slider_paprotka_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            paproc_kwadrat.Width = slider_paprotka.Value;
        }

        private void slider_brzoza_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brzoza_kwadrat.Width = slider_brzoza.Value;
        }

        private void slider_narcyz_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            narcyz_kwadrat.Width = slider_narcyz.Value;
        }

        private void slider_bambus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bambus_kwadrat.Width = slider_bambus.Value;
        }

        private void slider_aloes_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aloes_kwadrat.Width = slider_aloes.Value;
        }

        private void slider_irys_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            irys_kwadrat.Width = slider_irys.Value;
        }
    }
}
