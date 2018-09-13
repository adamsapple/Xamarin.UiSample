using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsPlugin.Iconize;

namespace UiSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : IconTabbedPage //TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            //Title = CurrentPage.Title;
        }

        /// <summary>
        /// (Android)Backボタンを押された時の処理
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            var nav = (Parent as NavigationPage)?.Navigation;

            if (nav == null)
            {
                return true;
            }

            /// Navのスタックが詰まれていたら戻る
            if (nav.NavigationStack.Count > 1)
            {
                /// 戻る
                nav.PopAsync();
            }
            else
            {
                /// MasterPageの表示/非表示切替え
                //this.IsPresented = !this.IsPresented;
            }

            return true;
        }
    }
}