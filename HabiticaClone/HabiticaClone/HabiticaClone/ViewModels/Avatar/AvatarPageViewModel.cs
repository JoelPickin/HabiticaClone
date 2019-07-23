using HabiticaClone.Models.Avatars;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HabiticaClone.ViewModels.Avatar
{
    public class AvatarPageViewModel : BindableBase
    {
        public AvatarModel Avatar { get; set; }
        public AvatarPageViewModel()
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
    }
}
