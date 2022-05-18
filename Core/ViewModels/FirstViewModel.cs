using Core.Intrefaces;
using Core.Models;
using Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.ViewModels
{
    public  class FirstViewModel : MvxViewModel
    {
        private IMvxNavigationService navigationService;
        public FirstViewModel(IMvxNavigationService navigationService) 
        { 
            this.navigationService = navigationService;
        }

        #region LIVE
        public override void Prepare() 
        { 
            asset = new Asset();
            assets = new MvxObservableCollection<Asset>();
        }
        public override Task Initialize() { return base.Initialize(); }
        public override void ViewDisappeared() { navigationService.Close(this); }

        #endregion

        #region Properties
        private Asset asset;
        private MvxObservableCollection<Asset> assets;
        public Asset Asset
        {
            get { return asset; }
            set
            {
                asset = value;
                RaisePropertyChanged(() => Asset);
            }
        }
        public MvxObservableCollection<Asset> Assets
        {
            get { return assets; }
            set
            {
                assets = value;
                RaisePropertyChanged(() => Assets);
            }
        }
        #endregion

        #region Commands
        private MvxCommand addAsset;
        public IMvxCommand AddAsset => addAsset = addAsset ?? new MvxCommand(AddField);
        #endregion

        #region Methods
        private void AddField()
        {
            asset.Name = "Testowy";
            asset.Amount = 0.214;
            asset.Value = 10000;
            Assets.Add(asset);
        }
        #endregion
    }
}