using IMQ1.Reflection.Event.Library.Writer;
using IMQ1.Reflection.Event.Library.Writer.Interface;
using System;

namespace IMQ1.Reflection.Event.Library
{
    public class ClassWithEvent
    {
        private IWriter _writer;
        public event Func<string> _event;

        public ClassWithEvent() : this(new ConsoleWriter())
        {
        }

        public ClassWithEvent(IWriter writer)
        {
            _writer = writer;
        }

        public void Execute()
        {
            if (_event != null)
            {
                _writer.Write(_event());
            }
        }

        public string HelloSiarhei()
        {
            return "Hello Siarhei";
        }
    }
}
