using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDRApplication.core
{
    public class CustomAppStart : MvxAppStart
    {
        public IMvxNavigationService navigation;
        public CustomAppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService): base(app, mvxNavigationService)
        {
            navigation = mvxNavigationService;
        }
        protected override async Task NavigateToFirstViewModel(object hint = null)
        {
            await navigation.Navigate<viewmodels.MainMenuViewModel>();
        }
    }
}
