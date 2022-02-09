using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace BatteryDevice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        Button myBattery;
        Button myDeviceDe;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            
            myBattery = FindViewById<Button>(Resource.Id.button12);
            myDeviceDe = FindViewById<Button>(Resource.Id.button13);


            
            myBattery.Click += MyBattery_Click;
            myDeviceDe.Click += MyDeviceDe_Click;
        }
        private void MyBattery_Click(object sender, System.EventArgs e)
        {

            Intent j = new Intent(Application.Context, typeof(BatteryDe));
            StartActivity(j);
        }
        private void MyDeviceDe_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(DeviceDe));
            StartActivity(k);
        }
         private void MyPropertyDemo_Click(object sender, System.EventArgs e)
        {

        }





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}