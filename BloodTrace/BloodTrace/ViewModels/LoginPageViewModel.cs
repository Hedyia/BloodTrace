using BloodTrace.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BloodTrace.ViewModels
{
	public class LoginPageViewModel : BindableBase
	{
        private INavigationService _navigationService;
        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        void ExecuteLoginCommand()
        {
            _navigationService.NavigateAsync("HomePage");
        }
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
	}
}
