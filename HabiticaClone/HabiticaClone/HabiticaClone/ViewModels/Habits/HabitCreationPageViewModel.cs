using HabiticaClone.Enums;
using HabiticaClone.Events;
using HabiticaClone.Models.Habits;
using HabiticaClone.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
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
        public ICommand CreateCommand => _createCommand = _createCommand ?? new DelegateCommand(CompleteHabit);
        public ICommand SaveCommand {get; set;}
        public ICommand DeleteCommand {get; set;}
        private IEventAggregator _eventAggregator;

        public string TaskTitle {get; set;}
        public string Notes {get; set;}
        public bool PositiveSelected {get; set;} = true;
        public bool NegativeSelected {get; set;} = true;
        public Difficulty SelectedDifficulty {get; set;} = Difficulty.Easy;
        public ResetStreak SelectedResetStreak {get; set;} = ResetStreak.Daily;

        public int PositiveStreak {get; set;}
        public int NegativeStreak {get; set;}

        public HabitCreationPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator /*IEventSubscriber eventSubscriber*/)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        public void CompleteHabit()
        {
            var habit = CreateHabit();

            if (habit == null) return;

            _eventAggregator.GetEvent<HabitCreatedEvent>().Publish(habit);
        }

        private Habit CreateHabit()
        {
            var habit = new Habit
            {
                TaskTitle = TaskTitle,
                Notes = Notes,
                PositiveSelected = PositiveSelected,
                NegativeSelected = NegativeSelected,
                Difficulty = SelectedDifficulty,
                ResetStreak = SelectedResetStreak
            };

            return habit;
        }
    }
}
