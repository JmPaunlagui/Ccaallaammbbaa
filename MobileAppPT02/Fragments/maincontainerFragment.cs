using System;
using System.Collections.Generic;
using Android.OS;
using Android.Views;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Android.Widget;

namespace MobileAppPT02.Fragments
{
    public class MaincontainerFragment : Android.Support.V4.App.Fragment
    {
        private SupportFragment mCurrentFragment;
        private FoodFragment mFragment1;
        private TouristFragment mFragment2;
        private HistoryFragment mFragment3;
        private Stack<SupportFragment> mStackFragment;
        BottomNavigationView bottomNavigation;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment her     
            
        }
        
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragmentMainContainer, container, false);

            bottomNavigation = view.FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView1);
            bottomNavigation.NavigationItemSelected += (s, e) => {
                Android.Support.V4.App.Fragment fragment = null;
                switch (e.Item.ItemId)
                {
                    case Resource.Id.Food:
                        fragment = new FoodFragment();
                        break;
                    case Resource.Id.Tourist:
                        fragment = new TouristFragment();
                        break;
                    case Resource.Id.History:
                        fragment = new HistoryFragment();
                        break;
                }
                Activity.SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.frameLayout1, fragment)
                .Commit();
                return;
            };

            mFragment1 = new FoodFragment();
            mFragment2 = new TouristFragment();
            mFragment3 = new HistoryFragment();

            mStackFragment = new Stack<SupportFragment>();

            var trans = Activity.SupportFragmentManager.BeginTransaction();

            trans.Add(Resource.Id.frameLayout1, mFragment3, "HistoryFragment");//NOT bottom_navigation, it must be the container
            trans.Hide(mFragment3);
            trans.Add(Resource.Id.frameLayout1, mFragment2, "TouristFragment");
            trans.Hide(mFragment2);
            trans.Add(Resource.Id.frameLayout1, mFragment1, "FoodFragment");

            trans.Commit();

            mCurrentFragment = mFragment1;

            return view;

        }
       
    }
}