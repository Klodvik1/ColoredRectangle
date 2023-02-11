using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using Tmds.DBus;

namespace ColoredRectangle.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string rectangleColor = "LightGray";

        public MainWindowViewModel()
        {
            ButtonClick = ReactiveCommand.Create<string, string>(str => RectangleColor = str);
        }
        public string RectangleColor
        {
            get => rectangleColor;
            set
            {
                this.RaiseAndSetIfChanged(ref rectangleColor, value);
            }
        }

        public ReactiveCommand<string, string> ButtonClick { get; }
    }
}
