using BloodTrace.Models;
using BloodTrace.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BloodTrace.ViewModels
{
	public class LatestDonarsViewModel : BindableBase, INavigatedAware
	{
        private INavigationService _navigationService;
        private ObservableCollection<Donator> _donators = StaticDonators.Donators;
        public ObservableCollection<Donator> Donators
        {
            get { return _donators; }
            set { SetProperty(ref _donators, value); }
        }

        private Donator _selectedDonator;
        public Donator SelectedDonator
        {
            get { return _selectedDonator; }
            set { SetProperty(ref _selectedDonator, value); }
        }
        private DelegateCommand _navigateDonatorCommand;
        public DelegateCommand NavigateDonatorCommand =>
            _navigateDonatorCommand ?? (_navigateDonatorCommand = new DelegateCommand(ExecuteNavigateDonatorCommand));

        void ExecuteNavigateDonatorCommand()
        {
            var p = new NavigationParameters();
            p.Add("1", SelectedDonator);

            _navigationService.NavigateAsync(nameof(DonatorDetailPage), p);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var p = parameters["1"] as string;
            if (p == "1")
            {
                Donators = StaticDonators.SearchedDontrors;

            }
        }

        public LatestDonarsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
	}
}
