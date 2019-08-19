using HabiticaClone.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }
        //public IEventAggregator EventAggregator { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService/*, IEventAggregator eventAggregator*/)
        {
            NavigationService = navigationService;
            //EventAggregator = eventAggregator;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        //private void AddEventSubscriptionsInternal(IEventSubscriber subscriber)
        //{
        //    AddEventSubscriptions(subscriber);
        //}
        //protected virtual void AddEventSubscriptions(IEventSubscriber subscriber)
        //{

        //}

        public virtual void Destroy()
        {

        }
    }
}
