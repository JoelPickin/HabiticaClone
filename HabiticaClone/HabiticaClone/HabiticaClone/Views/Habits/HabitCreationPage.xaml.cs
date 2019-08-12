using Xamarin.Forms;

namespace HabiticaClone.Views.Habits
{
    public partial class HabitCreationPage : ContentPage
    {
        public bool IsPositiveSelected { get; set;}
        public bool IsNegativeSelected { get; set; }

        public HabitCreationPage()
        {
            InitializeComponent();
        }

        private void PositiveButton_Clicked(object sender, System.EventArgs e)
        {
            if (!IsPositiveSelected)
            {
                IsPositiveSelected = true;
                PositiveButton.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                PositiveButton.TextColor = Color.White;
                PositiveButton.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
            }
            else
            {
                IsPositiveSelected = false;
                PositiveButton.BackgroundColor = Color.Transparent;
                PositiveButton.TextColor = Color.LightGray;
                PositiveButton.BorderColor = Color.LightGray;
            }
        }
        private void NegativeButton_Clicked(object sender, System.EventArgs e)
        {
            if (!IsNegativeSelected)
            {
                IsNegativeSelected = true;
                NegativeButton.BackgroundColor = (Color)Application.Current.Resources["MainColorPurple"];
                NegativeButton.TextColor = Color.White;
                NegativeButton.BorderColor = (Color)Application.Current.Resources["MainColorPurple"];
            }
            else
            {
                IsNegativeSelected = false;
                NegativeButton.BackgroundColor = Color.Transparent;
                NegativeButton.TextColor = Color.LightGray;
                NegativeButton.BorderColor = Color.LightGray;
            }
        }
    }
}
