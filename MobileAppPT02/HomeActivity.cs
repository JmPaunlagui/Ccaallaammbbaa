using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MobileAppPT02
{
    [Activity(Label = "HomeActivity", Theme = "@style/AppTheme")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_home);
        }

        public override void OnBackPressed()
        {
            AlertDialog.Builder alertdiag = new AlertDialog.Builder(this);
            alertdiag.SetTitle("Confirm Exit");
            alertdiag.SetMessage("Do you want to Exit?");
            alertdiag.SetPositiveButton("Yes", (senderAlert, args) => {
                OnDestroy();
                Finish();
            });
            alertdiag.SetNegativeButton("No", (senderAlert, args) => {
                alertdiag.Dispose();
                Toast.MakeText(this, "Thank you for Staying, \n Unlike your EX hahaha", ToastLength.Short).Show();
            });
            Dialog diag = alertdiag.Create();
            diag.Show();
        }
    }
}