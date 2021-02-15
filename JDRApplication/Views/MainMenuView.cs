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
using JDRApplication.core.viewmodels;
using MvvmCross.Platforms.Android.Views;

namespace JDRApplication.Views
{
    [Activity(Label = "MainMenuView", MainLauncher = true)]
    public class MainMenuView : BaseView<MainMenuViewModel>
    {
        protected  override int LayoutResource => Resource.Layout.MainMenuView;
    }
}