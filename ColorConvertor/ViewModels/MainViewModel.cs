using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;

namespace ColorConvertor.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private byte _red;
        private byte _green;
        private byte _blue;
        private SolidColorBrush _rgb;

        public MainViewModel()
        {
            Red = 100;
            Green = 100;
            Blue = 100;
        }

        public byte Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("RGB");
                NotifyPropertyChanged("Luminance");
                NotifyPropertyChanged("Brightness");
            }
        }
        public byte Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("RGB");
                NotifyPropertyChanged("Luminance");
                NotifyPropertyChanged("Brightness");
            }
        }
        public byte Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("RGB");
                NotifyPropertyChanged("Luminance");
                NotifyPropertyChanged("Brightness");
            }
        }
        public SolidColorBrush RGB
        {
            
            get
            {
                return new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
            }
        }
        public double Luminance
        {
            get
            {
                return Math.Round((0.2126 * Red + 0.7152 * Green + 0.0722 * Blue), 2);
            }
        }
        public double Brightness
        {
            get
            {
                return Math.Round((0.299 * Red + 0.287 * Green + 0.114 * Blue), 2);
            }
        }
    }
}