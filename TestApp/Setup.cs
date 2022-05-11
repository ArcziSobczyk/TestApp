using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core;
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
	public class Setup : MvxAndroidSetup<App>
	{
		protected override ILoggerFactory CreateLogFactory()
		{
			return null;
		}

		protected override ILoggerProvider CreateLogProvider()
		{
			return null;
		}
	}
}