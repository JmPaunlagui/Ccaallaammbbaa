using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Facebook.Shimmer;

namespace MobileAppPT02.Fragments
{
    public class HomeFragment : Android.Support.V4.App.Fragment
    {
        private ShimmerFrameLayout mShimmerViewContainer;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragmentHome, container, false);
           mShimmerViewContainer = view.FindViewById<ShimmerFrameLayout>(Resource.Id.shimmer_view_container);
            mShimmerViewContainer.Duration = (5000);           
            mShimmerViewContainer.Dropoff = 0.1f;
            mShimmerViewContainer.BaseAlpha = 0.3f;
            mShimmerViewContainer.Intensity = (0.35f);
            mShimmerViewContainer.Angle = ShimmerFrameLayout.MaskAngle.Cw180;

            return view;
        }
        public override void OnStart()
        {
            base.OnStart();
        }
        public override void OnResume()
        {
            base.OnResume();
            mShimmerViewContainer.StartShimmerAnimation();
        }
        public override void OnPause()
        {
            mShimmerViewContainer.StopShimmerAnimation();
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