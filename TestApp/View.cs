using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using MvvmCross.Platforms.Android.Views;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class View : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}