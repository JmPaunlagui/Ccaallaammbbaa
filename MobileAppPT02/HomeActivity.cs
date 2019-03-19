using System;
using System.Collections.Generic;
using Android.Support.V4.App;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;
using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using MobileAppPT02.Fragments;

using Android.Support.V7.App;
using Android.Support.V4.View;

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

            ViewPager viewPagerr = FindViewById<ViewPager>(Resource.Id.viewPager);
            SetUpViewPager(viewPagerr);

        }

        private void SetUpViewPager(ViewPager viewPagerr)
        {
            TabAdapter adapter = new TabAdapter(SupportFragmentManager);
            adapter.AddFragment(new HomeFragment(), "HomeFragment");
            adapter.AddFragment(new MaincontainerFragment(), "MaincontainerFragment");
            adapter.AddFragment(new AboutFragment(), "AboutFragment");

            viewPagerr.Adapter = adapter;
        }        

        public class TabAdapter : FragmentPagerAdapter
        {
            public List<SupportFragment> Fragmentss { get; set; }
            public List<string> FragmentNames { get; set; }

            public TabAdapter(SupportFragmentManager sfm) : base(sfm)
            {
                Fragmentss = new List<SupportFragment>();
                FragmentNames = new List<string>();
            }
            public void AddFragment(SupportFragment fragment, string name)
            {
                Fragmentss.Add(fragment);
                FragmentNames.Add(name);
            }
            public override int Count
            {
                get
                {
                    return Fragmentss.Count;
                }
            }
            public override SupportFragment GetItem(int position)
            {
                return Fragmentss[position];
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
        protected override void OnPause()
        {
            base.OnPause();
        }
        protected override void OnStop()
        {
            base.OnStop();
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
       
    }
}