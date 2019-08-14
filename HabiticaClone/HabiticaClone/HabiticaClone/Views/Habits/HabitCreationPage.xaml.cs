using HabiticaClone.ViewModels.Habits;
using Xamarin.Forms;

namespace HabiticaClone.Views.Habits
{
    public partial class HabitCreationPage : ContentPage
    {
        public HabitCreationPageViewModel ViewModel { get; set; }
        public bool IsPositiveSelected { get; set;} = true;
        public bool IsNegativeSelected { get; set; } = true;
        public bool IsTrivialSelected { get; set; }
        public bool IsEasySelected { get; set; } = true;
        public bool IsMediumSelected { get; set; }
        public bool IsHardSelected { get; set; }
        public bool IsDailySelected { get; set; } = true;
        public bool IsWeeklySelected { get; set; }
        public bool IsMonthlySelected { get; set; }

        public HabitCreationPage()
        {
            InitializeComponent();

            ViewModel = (HabitCreationPageViewModel)this.BindingContext;
        }

        private void PositiveBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsPositiveSelected)
            {
                IsPositiveSelected = true;

                PositiveBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                PositiveBtn.TextColor = Color.White;
                PositiveBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                PositiveLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];
            }
            else
            {
                IsPositiveSelected = false;

                PositiveBtn.BackgroundColor = Color.Transparent;
                PositiveBtn.TextColor = Color.Gray;
                PositiveBtn.BorderColor = Color.Gray;
                PositiveLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }

            ViewModel.PositiveSelected = IsPositiveSelected;
        }
        private void NegativeBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsNegativeSelected)
            {
                IsNegativeSelected = true;

                NegativeBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                NegativeBtn.TextColor = Color.White;
                NegativeBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                NegativeLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];
            }
            else
            {
                IsNegativeSelected = false;

                NegativeBtn.BackgroundColor = Color.Transparent;
                NegativeBtn.TextColor = Color.Gray;
                NegativeBtn.BorderColor = Color.Gray;
                NegativeLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }

            ViewModel.NegativeSelected = IsNegativeSelected;
        }

        private void TrivialBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsTrivialSelected)
            {
                IsTrivialSelected = true;
                TrivialBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                TrivialBtn.TextColor = Color.White;
                TrivialBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                TrivialLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsEasySelected = false;
                EasyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyBtn.TextColor = Color.Gray;
                EasyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsMediumSelected = false;
                MediumBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumBtn.TextColor = Color.Gray;
                MediumBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsHardSelected = false;
                HardBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardBtn.TextColor = Color.Gray;
                HardBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedDifficulty = Enums.Difficulty.Trivial;
            }
            else
            {
                IsTrivialSelected = false;
                TrivialBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialBtn.TextColor = Color.Gray;
                TrivialBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void EasyBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsEasySelected)
            {
                IsEasySelected = true;
                EasyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                EasyBtn.TextColor = Color.White;
                EasyBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                EasyLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsTrivialSelected = false;
                TrivialBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialBtn.TextColor = Color.Gray;
                TrivialBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsMediumSelected = false;
                MediumBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumBtn.TextColor = Color.Gray;
                MediumBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsHardSelected = false;
                HardBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardBtn.TextColor = Color.Gray;
                HardBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedDifficulty = Enums.Difficulty.Easy;
            }
            else
            {
                IsEasySelected = false;
                EasyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyBtn.TextColor = Color.Gray;
                EasyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void MediumBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsMediumSelected)
            {
                IsMediumSelected = true;
                MediumBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                MediumBtn.TextColor = Color.White;
                MediumBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                MediumLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsTrivialSelected = false;
                TrivialBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialBtn.TextColor = Color.Gray;
                TrivialBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsEasySelected = false;
                EasyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyBtn.TextColor = Color.Gray;
                EasyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsHardSelected = false;
                HardBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardBtn.TextColor = Color.Gray;
                HardBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedDifficulty = Enums.Difficulty.Medium;
            }
            else
            {
                IsMediumSelected = false;
                MediumBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumBtn.TextColor = Color.Gray;
                MediumBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void HardBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsHardSelected)
            {
                IsHardSelected = true;
                HardBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                HardBtn.TextColor = Color.White;
                HardBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
                HardLabel.TextColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsTrivialSelected = false;
                TrivialBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialBtn.TextColor = Color.Gray;
                TrivialBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                TrivialLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsEasySelected = false;
                EasyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyBtn.TextColor = Color.Gray;
                EasyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                EasyLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsMediumSelected = false;
                MediumBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumBtn.TextColor = Color.Gray;
                MediumBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MediumLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedDifficulty = Enums.Difficulty.Hard;
            }
            else
            {
                IsHardSelected = false;
                HardBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardBtn.TextColor = Color.Gray;
                HardBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
                HardLabel.TextColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void DailyBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsDailySelected)
            {
                IsDailySelected = true;
                DailyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                DailyBtn.TextColor = Color.White;
                DailyBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsWeeklySelected = false;
                WeeklyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                WeeklyBtn.TextColor = Color.Gray;
                WeeklyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsMonthlySelected = false;
                MonthlyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MonthlyBtn.TextColor = Color.Gray;
                MonthlyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedResetStreak = Enums.ResetStreak.Daily;
            }
            else
            {
                IsDailySelected = false;
                DailyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                DailyBtn.TextColor = Color.Gray;
                DailyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void WeeklyBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsWeeklySelected)
            {
                IsWeeklySelected = true;
                WeeklyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                WeeklyBtn.TextColor = Color.White;
                WeeklyBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsDailySelected = false;
                DailyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                DailyBtn.TextColor = Color.Gray;
                DailyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsMonthlySelected = false;
                MonthlyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MonthlyBtn.TextColor = Color.Gray;
                MonthlyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedResetStreak = Enums.ResetStreak.Weekly;
            }
            else
            {
                IsWeeklySelected = false;
                WeeklyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                WeeklyBtn.TextColor = Color.Gray;
                WeeklyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }

        private void MonthlyBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!IsMonthlySelected)
            {
                IsMonthlySelected = true;
                MonthlyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                MonthlyBtn.TextColor = Color.White;
                MonthlyBtn.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];

                IsDailySelected = false;
                DailyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                DailyBtn.TextColor = Color.Gray;
                DailyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                IsWeeklySelected = false;
                WeeklyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                WeeklyBtn.TextColor = Color.Gray;
                WeeklyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];

                ViewModel.SelectedResetStreak = Enums.ResetStreak.Monthly;
            }
            else
            {
                IsMonthlySelected = false;
                MonthlyBtn.BackgroundColor = (Color)Application.Current.Resources["MainColorLightGray"];
                MonthlyBtn.TextColor = Color.Gray;
                MonthlyBtn.BorderColor = (Color)Application.Current.Resources["MainColorLightGray"];
            }
        }
    }
}
