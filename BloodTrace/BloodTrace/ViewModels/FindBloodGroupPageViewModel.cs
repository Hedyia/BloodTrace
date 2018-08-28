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
	public class FindBloodGroupPageViewModel : BindableBase
	{
        private INavigationService _navigationService;
        private ObservableCollection<Donator> _donators = StaticDonators.Donators;
        public ObservableCollection<Donator> Donators
        {
            get { return _donators; }
            set { SetProperty(ref _donators, value); }
        }
        

        private string _selectedCountry;
        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set { SetProperty(ref _selectedCountry, value); }
        }
        private Donator _selectedBloodGroup;
        public Donator SelectedBloodGroup
        {
            get { return _selectedBloodGroup; }
            set { SetProperty(ref _selectedBloodGroup, value); }
        }
        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand =>
            _searchCommand ?? (_searchCommand = new DelegateCommand(ExecuteSearchCommand));

        void ExecuteSearchCommand()
        {
            var p = new NavigationParameters();
            p.Add("1", "1");
            var donatorsList = Donators.Where(d => d.BloodGroup == SelectedBloodGroup.BloodGroup).ToList();
            ObservableCollection<Donator> donators = new ObservableCollection<Donator>(donatorsList);
            StaticDonators.SearchedDontrors = donators;
            _navigationService.NavigateAsync(nameof(LatestDonars), p);
        }
        public FindBloodGroupPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
	}
}
