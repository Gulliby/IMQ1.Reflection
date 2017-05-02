using IMQ1.Reflection.List.Executor.TestClass;
using IMQ1.Reflection.List.Library;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.Reflection.List.Executor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customType = typeof(User);

            IList customList = ListBuilder.Build(customType); 

            customList.Add(new User
            {
                Id = 1,
                Name = "Ilya",
                Login = "Privet"
            });
            customList.Add(new User
            {
                Id = 2,
                Name = "Siarhei",
                Login = "Poka"
            });

            PrintList(customList);

            Console.ReadKey();
        }


        static void PrintList(IList list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(JObject.FromObject(element));
            }
        }
    }
}
