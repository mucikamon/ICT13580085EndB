﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ICT13580085EndB.Droid
{
    [Activity(Label = "ICT13580085EndB", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            dbPath = System.IO.Path.Combine(dbPath, "myshop.db3");
            LoadApplication(new App(dbPath));

        }
    }
}

