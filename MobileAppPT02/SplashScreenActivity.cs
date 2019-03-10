using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Util;
using System.Threading.Tasks;
using Android.Content;

namespace MobileAppPT02
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : AppCompatActivity
    {
        static readonly string TAG = "X: " + typeof(SplashScreenActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistableBundle)
        {
            base.OnCreate(savedInstanceState, persistableBundle);
            Log.Debug(TAG, "SplashScreenActivity.OnCreate");
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task Startup = new Task(() => { SimulateStartup(); });
            Startup.Start();
        }
        public override void OnBackPressed() { }

        async void SimulateStartup()
        {
            Log.Debug(TAG, "Performing Start Up");
            await Task.Delay(1000);
            Log.Debug(TAG, "Starting HomeActivity");
            StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
        }
    }
}