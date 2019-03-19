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

namespace MobileAppPT02.FragmentsForFoods.FRating
{
    public class IPrating : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View vvv = inflater.Inflate(Resource.Layout.Bottom_sheet_IP_Rating ,container, false);
            return vvv;
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