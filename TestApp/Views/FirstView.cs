using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace TestApp.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class FirstView : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}