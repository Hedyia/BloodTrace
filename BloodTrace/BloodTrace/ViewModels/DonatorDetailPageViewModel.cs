using BloodTrace.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloodTrace.ViewModels
{
	public class DonatorDetailPageViewModel : BindableBase, INavigatedAware
	{
        private Donator _donator;
        public Donator Donator
        {
            get { return _donator; }
            set { SetProperty(ref _donator, value); }
        }
        public DonatorDetailPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Donator = parameters["1"] as Donator;
        }
    }
}
