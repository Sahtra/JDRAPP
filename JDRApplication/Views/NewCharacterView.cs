﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using JDRApplication.core.viewmodels;

namespace JDRApplication.Views
{
    [Activity(Label = "NewCharacterView")]
    public class NewCharacterView : BaseView<GenerateViewModel>
    {
        protected override int LayoutResource => Resource.Layout.newcharacterview;
    }
}