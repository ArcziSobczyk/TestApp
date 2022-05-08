using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public  class FirstViewModel : MvxViewModel
    {
        private Service service;
        public FirstViewModel(Service service) { this.service = service; }

        
    }
}