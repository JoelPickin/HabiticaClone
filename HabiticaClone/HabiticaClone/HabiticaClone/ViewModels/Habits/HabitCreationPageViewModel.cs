using HabiticaClone.Enums;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HabiticaClone.ViewModels.Habits
{
    public class HabitCreationPageViewModel : ViewModelBase
    {
        private DelegateCommand _createCommand;
        public ICommand CreateCommand => _createCommand = _createCommand ?? new DelegateCommand(CreateHabit);
        public ICommand SaveCommand {get; set;}
        public ICommand DeleteCommand {get; set;}
        public string TaskTitle {get; set;}
        public string Notes {get; set;}
        public bool PositiveSelected {get; set;} = true;
        public bool NegativeSelected {get; set;} = true;
        public Difficulty SelectedDifficulty {get; set;} = Difficulty.Easy;
        public ResetStreak SelectedResetStreak {get; set;} = ResetStreak.Daily;

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

        public void CreateHabit()
        {

        }
    }
}
