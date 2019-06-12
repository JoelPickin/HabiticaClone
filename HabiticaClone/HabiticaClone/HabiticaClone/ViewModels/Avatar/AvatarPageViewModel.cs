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
        public AvatarPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

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
