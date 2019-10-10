using HabiticaClone.Common.Services.Navigation;
using HabiticaClone.Events;
using HabiticaClone.Models.Avatars;
using HabiticaClone.Models.Habits;
using HabiticaClone.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HabiticaClone.ViewModels.Habits
{
    public class HabitsPageViewModel : ViewModelBase
    {
        public ICommand PositiveCommand {get; set;}
        public ICommand NegativeCommand {get; set;}
        private Command _itemSelectedCommand { get; set; }
        public ICommand ItemSelectedCommand => _itemSelectedCommand = _itemSelectedCommand ?? new Command(ItemSelected);
        public ICommand GoToHabitDetailCommand {get; set;}
        private Command _goToHabitCreationCommand;
        public ICommand GoToHabitCreationCommand => _goToHabitCreationCommand = _goToHabitCreationCommand ?? new Command<NavigationParameters>(async (navParams) => await GoToHabitCreation(navParams));
        private IEventAggregator _eventAggregator;

        public ObservableCollection<Habit> HabitList {get; set;}
        public AvatarModel Avatar { get; set; }

        private Habit _selectedItem;
        public Habit SelectedItem 
        { 
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
            }
        }


        public HabitsPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            AddEventSubscriptions();

            HabitList = new ObservableCollection<Habit>
            {
                new Habit
                {
                    TaskTitle = "This is a test",
                    Notes = "These are some test notes added ot this"
                },
                new Habit
                {
                    TaskTitle = "This is a test",
                    Notes = "These are some test notes added ot this"
                },
                new Habit
                {
                    TaskTitle = "This is a test",
                    Notes = "These are some test notes added ot this"
                }
            };

            Avatar = new AvatarModel
            {
                UserName = "Joel Pickin",
                Level = 1,
                MaxHealth = 50,
                CurrentHealth = 29,
                MaxExperience = 150,
                CurrentExperience = 12,
                GoldOwned = 2.02,
                GemsOwned = 0
            };         
        }

        protected override void AddEventSubscriptions()
        {
            _eventAggregator.GetEvent<HabitCreatedEvent>().Subscribe(async (habit) => await UpdateHabitListAsync(habit));
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            var realmDb = Realm.GetInstance();

            var habits = realmDb.All<Habit>().ToList();
        }

        private async void ItemSelected()
        {
            if (SelectedItem != null && SelectedItem is Habit)
            {
                NavigationParameters navParams = new NavigationParameters();
                navParams.Add(NavParams.SelectedItem, SelectedItem);

                await GoToHabitCreation(navParams);
            }
        }

        private async Task GoToHabitCreation(NavigationParameters navParams)
        {
           await NavigationService.NavigateAsync(NavPages.HabitCreationPage, navParams);
        }

        private async Task UpdateHabitListAsync(Habit habit)
        {
            HabitList.Add(habit);
            await NavigationService.GoBackAsync();
        }

    }
}
