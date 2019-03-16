using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using MobileAppPT02.FragmentsForTourist;

namespace MobileAppPT02.Fragments
{
    public class TouristFragment : Android.Support.V4.App.Fragment
    {

        private CardView cvRS1, cvSJBC1;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragmentTourist, container, false);

            cvRS1 = view.FindViewById<CardView>(Resource.Id.cvRS);
            cvSJBC1 = view.FindViewById<CardView>(Resource.Id.cvSJBC);

            cvRS1.Click += CvRS_Click;
            cvSJBC1.Click += CvSJBC_Click;

            return view;
        }

        private void CvSJBC_Click(object sender, EventArgs e)
        {
            var transs = Activity.SupportFragmentManager.BeginTransaction();
            transs.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            transs.Replace(Resource.Id.fragmentContainer, new SJBCFragment(), "SJBCFragment");
            transs.AddToBackStack(null);
            transs.Commit();
            return;
        }

        private void CvRS_Click(object sender, EventArgs e)
        {
            var trans = Activity.SupportFragmentManager.BeginTransaction();
            trans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            trans.Replace(Resource.Id.fragmentContainer, new RizalSFragment(), "RizalSFragment");
            trans.AddToBackStack(null);
            trans.Commit();
            return;
        }
    }
}
