using HabiticaClone.Models.Habits;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Events
{    
    public class HabitCreatedEvent : PubSubEvent<Habit>
    {

    }
}
