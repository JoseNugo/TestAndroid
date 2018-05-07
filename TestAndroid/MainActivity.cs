using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestAndroid
{
    [Activity(Label = "TestAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            AppCenter.Start("5fdd6365-1fc6-47b3-b67f-d972b03b9ec1",
                   typeof(Analytics), typeof(Crashes));
             
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

