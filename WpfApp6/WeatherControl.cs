using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp6
{

    class WeatherControl:DependencyObject
    {
        public static readonly DependencyProperty TemperProperty;
        public string direction;
        public int speed;
        public string precipitate;

        public int Temper
        {       
            get => (int) GetValue(TemperProperty);
            set => SetValue(TemperProperty, value);
        }    

        public string Direction
        {
            get => direction;
            set => direction = value;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public string Precipitate
        {
            get => precipitate;
            set => precipitate = value;
        }

        static WeatherControl()
        {
            TemperProperty = DependencyProperty.Register(
                nameof(Temper),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    null,
                    new CoerceValueCallback(CoerceWeather)),
                new ValidateValueCallback(ValidateWeather));
        }

        private static bool ValidateWeather(object value)
        {
            int v = (int)value;
            if (v > -50 && v < 50)
                return true;
            else
                return false;
        }

        private static object CoerceWeather(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v > -50 && v < 50)
                return v;
            else
                return 0;
        }

        public void ShowWeather()
        {
            MessageBox.Show($"Температура: {Temper.ToString()} *С, направление ветра: {Direction}, скорость ветра: {Speed} м/c осадки: {Precipitate}");
        }
    }
}
