using JDRApplication.data.Entities;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDRApplication.core.viewmodels
{
    public class AllCharactersViewModel : BaseViewModel
    {

        public List<CharacterEntity> myCharacters;

        public AllCharactersViewModel(IMvxNavigationService nav) : base(nav)
        {
            myCharacters = new List<CharacterEntity>();
        }


        public override Task Initialize()
        {
            myCharacters = data.DataAccess.GetAll();

            return base.Initialize();
        }

    }
}
