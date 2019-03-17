﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using MobileAppPT02.FragmentsForFoods.FRating;

namespace MobileAppPT02.FragmentsForFoods
{
    public class DingHaoFragment : Android.Support.V4.App.Fragment
    {

        private FloatingActionButton DHfloat;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragmentDingHao, container, false);

            Android.Support.V7.Widget.Toolbar toolbar = view.FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.tooLbar);
            toolbar.Title = "Ding Hao";

            DHfloat = view.FindViewById<FloatingActionButton>(Resource.Id.dhFloatAB);
            DHfloat.Click += (s, e) => {
                var trans = Activity.SupportFragmentManager.BeginTransaction();
                trans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
                trans.Replace(Resource.Id.fragmentContainer, new DHrating(), "DHrating");
                trans.AddToBackStack(null);
                trans.Commit();
                return;
            };

            return view;
        }

       
    }
}