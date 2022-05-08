using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Setup : MvxAndroidSetup
    {
        private Context context;
        public Setup(Context applicationContext)
        {
            this.context = applicationContext;
        }

        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            //throw new NotImplementedException();
            return null;
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            throw new NotImplementedException();
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            throw new NotImplementedException();
        }
    }
}