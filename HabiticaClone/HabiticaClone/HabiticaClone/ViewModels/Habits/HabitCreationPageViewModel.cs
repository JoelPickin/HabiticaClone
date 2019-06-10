using HabiticaClone.Enums;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace HabiticaClone.ViewModels.Habits
{
    public class HabitCreationPageViewModel : ViewModelBase
    {
        public ICommand CreateCommand {get; set;}
        public ICommand SaveCommand {get; set;}
        public ICommand DeleteCommand {get; set;}
        public string TaskTitle {get; set;}
        public string Notes {get; set;}
        public bool PositiveSelected {get; set;}
        public bool NegativeSelected {get; set;}
        public Difficulty SelectedDifficulty {get; set;}
        public ResetStreak SelectedResetStreak {get; set;}
        public int PositiveStreak {get; set;}
        public int NegativeStreak {get; set;}

        public HabitCreationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
