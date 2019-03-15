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
using MobileAppPT02.FragmentsForFoods;

namespace MobileAppPT02.Fragments
{
    public class FoodFragment : Android.Support.V4.App.Fragment
    {

        private CardView cvDTH1, cvDH1, cvTTS1, cvIP1;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View viewFood = inflater.Inflate(Resource.Layout.fragmentFood, container, false);

            //CardView ID
            cvDTH1 = viewFood.FindViewById<CardView>(Resource.Id.cvDTH);            
            cvDH1 = viewFood.FindViewById<CardView>(Resource.Id.cvDH);
            cvTTS1 = viewFood.FindViewById<CardView>(Resource.Id.cvTTS);
            cvIP1 = viewFood.FindViewById<CardView>(Resource.Id.cvIP);


            //Click listener
            cvDTH1.Click += CvDTH_Click;
            cvDH1.Click += CvDH_Click;
            cvTTS1.Click += CvTTS_Click;
            cvIP1.Click += CvIP_Click;
      
            return viewFood;
        }

        private void CvIP_Click(object sender, EventArgs e)
        {
            var transsss = Activity.SupportFragmentManager.BeginTransaction();
            transsss.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            transsss.Replace(Resource.Id.fragmentContainer, new IpponYariFragment(), "IpponYariFragment");
            transsss.AddToBackStack(null);
            transsss.Commit();
        }

        private void CvTTS_Click(object sender, EventArgs e)
        {
            var transss = Activity.SupportFragmentManager.BeginTransaction();
            transss.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            transss.Replace(Resource.Id.fragmentContainer, new TonTonsFragment(), "TonTonsFragment");           
            transss.AddToBackStack(null);
            transss.Commit();
        }

        private void CvDH_Click(object sender, EventArgs e)
        {
            var transs = Activity.SupportFragmentManager.BeginTransaction();
            transs.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            transs.Replace(Resource.Id.fragmentContainer, new DingHaoFragment(), "DingHaoFragment");
            transs.AddToBackStack(null);
            transs.Commit();
        }

        private void CvDTH_Click(object sender, EventArgs e)
        {
            var trans = Activity.SupportFragmentManager.BeginTransaction();
            trans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);
            trans.Replace(Resource.Id.fragmentContainer, new DavidsTeaHouseFragment(), "DavidsTeaHouseFragment");
            trans.AddToBackStack(null);
            trans.Commit();
        }
    }
}