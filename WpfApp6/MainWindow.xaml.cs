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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Weather();
        }


        public void Weather()
        {
            WeatherControl weather = new WeatherControl();
            weather.Temper = 30;
            weather.Direction = "Ю-З";
            weather.Precipitate = "Снег";
            weather.Speed = 20;
            weather.ShowWeather();
        }

    }


   
}
