using IMQ1.Reflection.Event.Library.Writer.Interface;
using System;

namespace IMQ1.Reflection.Event.Library.Writer
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
