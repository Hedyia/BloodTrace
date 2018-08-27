using BloodTrace.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloodTrace.ViewModels
{
	public class HomePageViewModel : BindableBase
	{
        private INavigationService _navigationService;
        private DelegateCommand _bloodGroupCommand;
        public DelegateCommand BloodGroupCommand =>
            _bloodGroupCommand ?? (_bloodGroupCommand = new DelegateCommand(ExecuteBloodGroupCommand));

        void ExecuteBloodGroupCommand()
        {
            _navigationService.NavigateAsync(nameof(FindBloodGroupPage));
        }
        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private DelegateCommand _registerBloodGroupCommand;
        public DelegateCommand RegisterBloodGroupCommand =>
            _registerBloodGroupCommand ?? (_registerBloodGroupCommand = new DelegateCommand(ExecuteRegisterBloodGroupCommand));

        void ExecuteRegisterBloodGroupCommand()
        {
            _navigationService.NavigateAsync(nameof(RegisterBloodGroupPage));

        }
        private DelegateCommand _latestDonatorsCommand;
        public DelegateCommand LatestDonatorsCommand =>
            _latestDonatorsCommand ?? (_latestDonatorsCommand = new DelegateCommand(ExecuteLatestDonatorsCommand));

        void ExecuteLatestDonatorsCommand()
        {
            _navigationService.NavigateAsync(nameof(LatestDonars));

        }
        private DelegateCommand _helpCommand;
        public DelegateCommand HelpCommand =>
            _helpCommand ?? (_helpCommand = new DelegateCommand(ExecuteHelpCommand));

        void ExecuteHelpCommand()
        {
            _navigationService.NavigateAsync(nameof(HelpPage));

        }
        private DelegateCommand _logoutCommand;
        public DelegateCommand LogoutCommand =>
            _logoutCommand ?? (_logoutCommand = new DelegateCommand(ExecuteLogoutCommand));

        void ExecuteLogoutCommand()
        {
            _navigationService.NavigateAsync(nameof(LoginPage));
        }
    }
}
