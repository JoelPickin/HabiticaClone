using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Services.Interfaces
{
    public interface IEventSubscriber
    {
        void Subscribe<TEvent, TPayload>(Action<TPayload> action, ThreadOption? option = null) where TEvent : PubSubEvent<TPayload>, new();
        void Subscribe<TEvent>(Action action, ThreadOption? option = null) where TEvent : PubSubEvent, new();
    }
}
