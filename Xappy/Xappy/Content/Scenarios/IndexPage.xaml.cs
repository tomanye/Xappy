﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xappy.Scenarios;

namespace Xappy.Scenarios
{
    public partial class IndexPage : ContentPage
    {
        public IndexPage()
        {
            InitializeComponent();

            BindingContext = new IndexPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ScenariosCV.SelectedItem = null;
        }
    }
}
