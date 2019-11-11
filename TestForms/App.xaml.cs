﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestForms
{
    public partial class App : Application
    {
        public static string DB_PATH = String.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string path) {

            InitializeComponent();

            DB_PATH = path;

            MainPage = new NavigationPage(new MainPage());

        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
