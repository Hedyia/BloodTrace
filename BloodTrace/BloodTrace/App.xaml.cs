using Prism;
using Prism.Ioc;
using BloodTrace.ViewModels;
using BloodTrace.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BloodTrace
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<HelpPage, HelpPageViewModel>();
            containerRegistry.RegisterForNavigation<FindBloodGroupPage, FindBloodGroupPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterBloodGroupPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<LatestDonars, LatestDonarsViewModel>();
            containerRegistry.RegisterForNavigation<DonatorDetailPage, DonatorDetailPageViewModel>();
        }
    }
}
