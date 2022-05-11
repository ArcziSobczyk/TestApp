using Core.Intrefaces;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.ViewModels
{
    public  class FirstViewModel : MvxViewModel
    {
        private readonly Interface service;
        public FirstViewModel(Interface service) { this.service = service; }

        
    }
}