using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDRApplication.core
{
    public abstract class BaseViewModel : MvxViewModel
    {
        public IMvxNavigationService navigationService;

        public BaseViewModel(IMvxNavigationService nav) : base()
        {
            navigationService = nav;
        }
    }
}
