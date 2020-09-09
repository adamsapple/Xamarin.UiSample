using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UiSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VsmTestPage : ContentPageEx
    {
        public VsmTestPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        GoToStateAllElements("State1");
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        GoToStateAllElements("State2");
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        GoToStateAllElements("State3");
    }
}
}