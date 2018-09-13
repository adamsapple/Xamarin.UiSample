﻿using System;

using UiSample.Views;
using Xamarin.Forms;

namespace UiSample
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new FormsPlugin.Iconize.IconNavigationPage(new TabbedPage1());
            //MainPage = new FormsPlugin.Iconize.IconNavigationPage(new Page1());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
