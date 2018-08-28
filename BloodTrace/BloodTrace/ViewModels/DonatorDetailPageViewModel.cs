using BloodTrace.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

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

        private DelegateCommand _callCommand;
        public DelegateCommand CallCommand =>
            _callCommand ?? (_callCommand = new DelegateCommand(ExecuteCallCommand));

        void ExecuteCallCommand()
        {
            string phoneNumber = Donator.Phone;

            if (string.IsNullOrEmpty(phoneNumber))
            {
                return;
            }

            // Following line used to display given phone number in dialer  
            Device.OpenUri(new Uri(String.Format("tel:{0}", phoneNumber)));
        }

        private DelegateCommand _emailCommand;
        public DelegateCommand EmailCommand =>
            _emailCommand ?? (_emailCommand = new DelegateCommand(ExecuteEmailCommand));

        void ExecuteEmailCommand()
        {
            string toEmail = Donator.Email;
            string emailSubject = "email subject ...";
            string emailBody = "email body...";

            if (string.IsNullOrEmpty(toEmail))
            {
                return;
            }

            Device.OpenUri(new Uri(String.Format("mailto:{0}?subject={1}&body={2}", toEmail, emailSubject, emailBody)));
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
