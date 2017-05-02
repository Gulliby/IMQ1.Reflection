using IMQ1.Reflection.Event.Library;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace IMQ1.Reflection.Event.Executor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var classWithEvent = new ClassWithEvent();

            var eventInfo = typeof(ClassWithEvent).GetEvent("_event");
            var methodInfo = typeof(ClassWithEvent).GetMethod("HelloSiarhei");

            var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, classWithEvent, methodInfo);
            eventInfo.AddEventHandler(classWithEvent, handler);

            classWithEvent.Execute();
        }
    }
}
