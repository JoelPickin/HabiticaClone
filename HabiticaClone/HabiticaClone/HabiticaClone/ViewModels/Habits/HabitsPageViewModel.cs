﻿using HabiticaClone.Models.Habits;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace HabiticaClone.ViewModels.Habits
{
    public class HabitsPageViewModel : ViewModelBase
    {
        public ICommand PositiveCommand {get; set;}
        public ICommand NegativeCommand {get; set;}
        public ICommand GoToHabitDetailCommand {get; set;}
        public ICommand GoToHabitCreationCommand {get; set;}
        public ObservableCollection<Habit> HabitList {get; set;}
        
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
