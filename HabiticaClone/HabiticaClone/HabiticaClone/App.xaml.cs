using Prism;
using Prism.Ioc;
using HabiticaClone.ViewModels;
using HabiticaClone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HabiticaClone.Views.Navigation;
using HabiticaClone.Views.Habits;
using HabiticaClone.ViewModels.Navigation;
using HabiticaClone.ViewModels.Habits;
using HabiticaClone.Views.Avatar;
using HabiticaClone.ViewModels.Avatar;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HabiticaClone
{
    public partial class App
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

            await NavigationService.NavigateAsync("MasterDetailNavPage");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedNavPage, TabbedNavPageViewModel>();
            containerRegistry.RegisterForNavigation<HabitsPage, HabitsPageViewModel>();
            containerRegistry.RegisterForNavigation<HabitCreationPage, HabitCreationPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailNavPage, MasterDetailNavPageViewModel>();
        }
    }
}
