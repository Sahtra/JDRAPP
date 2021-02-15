using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace JDRApplication.Views
{
    [Activity(Label = "SplashScreen", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.splashscreen)
        {

        }


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var tb = FindViewById<TextView>(Resource.Id.Version);
            tb.Text = ApplicationContext.PackageManager.GetPackageInfo(ApplicationContext.PackageName, 0).VersionName.ToString();

        }
    }
}