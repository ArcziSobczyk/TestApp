using Core.Intrefaces;
using Core.Services;
using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class App : MvxApplication
    {
		public override void Initialize()
		{
			base.Initialize();
			Mvx.IoCProvider.RegisterType<Interface, Service>();
			RegisterCustomAppStart<AppStart>();
		}
	}
}