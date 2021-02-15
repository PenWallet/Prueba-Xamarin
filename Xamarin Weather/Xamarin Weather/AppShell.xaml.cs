﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin_Weather.ViewModels;
using Xamarin_Weather.Views;

namespace Xamarin_Weather
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }

    }
}
