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
using JDRApplication.core;

namespace JDRApplication
{
    public abstract class BaseView<T> : MvxActivity<T> where T : BaseViewModel
    {
        protected virtual int LayoutResource { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainMenuView);
        }
    }
}