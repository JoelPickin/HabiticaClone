using HabiticaClone.Models.Avatars;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HabiticaClone.ViewModels.Avatar
{
    public class AvatarPageViewModel : ViewModelBase
    {
        public AvatarModel Avatar { get; set; }

        public AvatarPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
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

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }
    }
}
