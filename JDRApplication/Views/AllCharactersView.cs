using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using JDRApplication.Adapter;
using JDRApplication.core.viewmodels;

namespace JDRApplication.Views
{
    [Activity(Label = "AllCharactersView")]
    public class AllCharactersView : BaseView<AllCharactersViewModel>
    {
        protected override int LayoutResource => Resource.Layout.AllCharactersView;


        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            RecyclerView rcv = FindViewById<RecyclerView>(Resource.Id.MyListView);
            rcv.SetLayoutManager(new LinearLayoutManager(this));
            CharacterAdapter myAdapter = new CharacterAdapter(ViewModel.myCharacters);
            rcv.SetAdapter(myAdapter);


        }
    }
}