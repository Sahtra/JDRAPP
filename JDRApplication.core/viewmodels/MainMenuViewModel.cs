using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDRApplication.core.viewmodels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public string LabelTitle => "PNJ Generator";
        public string LabelMenuAll => "See all characters";
        public string LabelMenuGenerate => "Go to generator";


        private MvxAsyncCommand goToAll, goToGenerator;
        public MvxAsyncCommand GoToAll => goToAll ?? ( goToAll = new MvxAsyncCommand(GoToAllTask));
        public MvxAsyncCommand GoToGenerator => goToGenerator ?? (goToGenerator = new MvxAsyncCommand(GoToGeneratorTask));

        private async Task GoToAllTask()
        {

            using (Acr.UserDialogs.UserDialogs.Instance.Loading("Loading"))
            {
                await Task.Run(async () => { await navigationService.Navigate<AllCharactersViewModel>(); });
            }
             
            
            await navigationService.Close(this);
        }
        private async Task GoToGeneratorTask()
        {
           
            await navigationService.Navigate<GenerateViewModel>();
            await navigationService.Close(this);
        }

        public MainMenuViewModel(IMvxNavigationService navigation) : base(navigation)
        {
        }


    }
}
