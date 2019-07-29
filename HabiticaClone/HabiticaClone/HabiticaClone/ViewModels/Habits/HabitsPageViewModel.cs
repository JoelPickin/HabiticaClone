using HabiticaClone.Models.Avatars;
using HabiticaClone.Models.Habits;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace HabiticaClone.ViewModels.Habits
{
    public class HabitsPageViewModel : ViewModelBase
    {
        public ICommand PositiveCommand {get; set;}
        public ICommand NegativeCommand {get; set;}
        public ICommand GoToHabitDetailCommand {get; set;}

        private Command _goToHabitCreationCommand;
        public ICommand GoToHabitCreationCommand => _goToHabitCreationCommand = _goToHabitCreationCommand ?? new Command(GoToHabitCreation);

        public ObservableCollection<Habit> HabitList {get; set;}
        public AvatarModel Avatar { get; set; }


        public HabitsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
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

          public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        private async void GoToHabitCreation()
        {
           await NavigationService.NavigateAsync("HabitCreationPage");
        }
    }
}
