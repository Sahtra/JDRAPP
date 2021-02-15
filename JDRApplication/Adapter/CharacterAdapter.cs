﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using JDRApplication.data.Entities;

namespace JDRApplication.Adapter
{
    public class CharacterAdapter : RecyclerView.Adapter
    {
        private List<CharacterEntity> data;
        public override int ItemCount => data == null ? 0 : data.Count;


        public CharacterAdapter(List<CharacterEntity> data)
        {
            this.data = data;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(res, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            CharacterViewHolder viewholder = new CharacterViewHolder(itemView);


            return viewholder;
        }
    }


    public class CharacterViewHolder : RecyclerView.ViewHolder
    {
        public TextView TvLabelNom { get; set; }
        public TextView TvNom { get; set; }
        public TextView TvLabelRace { get; set; }
        public TextView TvRace { get; set; }
        public TextView TvLabelExtraction { get; set; }
        public TextView TvExtraction { get; set; }
        public TextView TvLabelDescription { get; set; }
        public TextView TvDescription { get; set; }
        public TextView TvPhysique { get; set; }
        public TextView TvMental { get; set; }
        public TextView TvSocial { get; set; }
        public TextView TvStrength { get; set; }
        public TextView TvAgility { get; set; }
        public TextView TvKnowledge { get; set; }
        public TextView TvInstinct { get; set; }
        public TextView TvRelation { get; set; }
        public TextView TvAura { get; set; }
        public TextView TvLife { get; set; }
        public TextView TvMana { get; set; }

        public CharacterViewHolder(View ItemView) : base(ItemView)
        {
            TvLabelNom = ItemView.FindViewById<TextView>(Resource.Id.TvLabelName);
            TvNom = ItemView.FindViewById<TextView>(Resource.Id.TvLabelName);
            TvLabelRace = ItemView.FindViewById<TextView>(Resource.Id.TvLabelRace);
            TvRace = ItemView.FindViewById<TextView>(Resource.Id.TvRace);
            TvLabelExtraction = ItemView.FindViewById<TextView>(Resource.Id.TvLabelExtraction);
            TvExtraction = ItemView.FindViewById<TextView>(Resource.Id.TvExtraction);
            TvLabelDescription = ItemView.FindViewById<TextView>(Resource.Id.TvLabelDescription);
            TvDescription = ItemView.FindViewById<TextView>(Resource.Id.TvDescription);
            TvPhysique = ItemView.FindViewById<TextView>(Resource.Id.TextViewPhysique);
            TvMental = ItemView.FindViewById<TextView>(Resource.Id.TextViewMental);
            TvSocial = ItemView.FindViewById<TextView>(Resource.Id.TextViewSocial);
            TvStrength = ItemView.FindViewById<TextView>(Resource.Id.TextViewStrength);
            TvAgility = ItemView.FindViewById<TextView>(Resource.Id.TextViewAgility);
            TvRelation = ItemView.FindViewById<TextView>(Resource.Id.TextViewRelation);
            TvAura = ItemView.FindViewById<TextView>(Resource.Id.TextViewAura);
            TvInstinct = ItemView.FindViewById<TextView>(Resource.Id.TextViewInstinct);
            TvKnowledge = ItemView.FindViewById<TextView>(Resource.Id.TextViewKnowledge);
            TvLife = ItemView.FindViewById<TextView>(Resource.Id.TextViewHealth);
            TvMana = ItemView.FindViewById<TextView>(Resource.Id.TvMana);
        }
    }
}