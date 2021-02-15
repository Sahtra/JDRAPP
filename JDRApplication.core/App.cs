using JDRApplication.core.viewmodels;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDRApplication.core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            RegisterAppStart<MainMenuViewModel>();
        }
    }
}
