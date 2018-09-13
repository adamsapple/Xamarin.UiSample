using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace UiSample.Droid
{
    [Activity(Label = "UiSample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            
            // Appending Iconize.(part 1)
            Plugin.Iconize.Iconize
                                .With(new Plugin.Iconize.Fonts.FontAwesomeModule())
                                .With(new Plugin.Iconize.Fonts.IoniconsModule())
                                .With(new Plugin.Iconize.Fonts.MaterialModule());

            global::Xamarin.Forms.Forms.Init(this, bundle);

            // Appending Iconize.(part 2)
            FormsPlugin.Iconize.Droid.IconControls.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs);
            //global::Plugin.Iconize.Iconize.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs); // Could also be Resource.Id.tab

            LoadApplication(new App());
        }
    }
}

