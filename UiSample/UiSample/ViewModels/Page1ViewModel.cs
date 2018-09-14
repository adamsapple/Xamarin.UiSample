using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using Xamarin.Forms;

namespace UiSample.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        int andgle = 50;
        public int Angle
        {
            get => andgle;
            set => SetProperty(ref andgle, value);
        }

        public ICommand PutAngleCommand { get; }

        public Page1ViewModel()
        {
            PutAngleCommand = new Command(() => System.Diagnostics.Debug.WriteLine(message: $"Execute:{Angle}"));
        }
    }
}
