using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V4.App;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MobileAppPT02.Fragments;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace MobileAppPT02
{
    [Activity(Label = "HomeActivity", Theme = "@style/AppTheme")]
    public class HomeActivity : AppCompatActivity
    {
        static readonly string TAG = "Y: " + typeof(HomeActivity).Name;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_home);
            Log.Debug(TAG, "Home activity deployed");

            TextView textView = FindViewById<TextView>(Resource.Id.OpenBottomSheet);
            textView.Click += TextView_Click;

        }

        private void TextView_Click(object sender, EventArgs e)
        {          
           var trans = SupportFragmentManager.BeginTransaction();
           trans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
           trans.Add(Resource.Id.fragmentContainer, new MaincontainerFragment(), "MaincontainerFragment" );
           trans.AddToBackStack(null);
           trans.Commit();
           return;
        }
    }
}