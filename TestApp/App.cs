using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    [Application]
    public class App : MvxApplication
    {
        public App(IntPtr javaReference, JniHandleOwnership transfer) : base()
        { 
        
        }

        public override void Initialize()
        {
            base.Initialize();
            Mvx.IoCProvider.RegisterType<Interface, Service>();
            RegisterAppStart<FirstViewModel>();
            
        }
    }
}