﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileDovzenok
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Valgusfoor2(); // стартовая страница
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
