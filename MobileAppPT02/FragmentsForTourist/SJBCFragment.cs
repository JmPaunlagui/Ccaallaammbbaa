using System;
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
using MobileAppPT02.FragmentsForTourist.TRating;

namespace MobileAppPT02.FragmentsForTourist
{
    public class SJBCFragment : Android.Support.V4.App.Fragment
    {
        private FloatingActionButton sjbcfloat;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragmentSJBC, container, false);

            Android.Support.V7.Widget.Toolbar toolbar = view.FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.tooLbar);
            toolbar.Title = "St. John the Baptist Church";

            sjbcfloat = view.FindViewById<FloatingActionButton>(Resource.Id.sjbcFloatAB);
            sjbcfloat.Click += (s, e)=>{
                var trans = ChildFragmentManager.BeginTransaction();

                trans.Replace(Resource.Id.frameSJBC, new SjbcRating(), "SjbcRating");
                trans.AddToBackStack(null);
                trans.Commit();
                return;
            };

            return view;
        }
        public override void OnResume()
        {
            base.OnResume();
        }
        public override void OnPause()
        {
            base.OnPause();
        }
        public override void OnStop()
        {
            base.OnStop();
        }
        public override void OnDestroyView()
        {
            base.OnDestroyView();
        }
        public override void OnDestroy()
        {
            base.OnDestroy();
        }
        public override void OnDetach()
        {
            base.OnDetach();
        }
    }
}