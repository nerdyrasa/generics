using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    class Program
    {
        static void Main(string[] args)
        {

            var employeeList = CreateCollection(typeof(List<>), typeof(Employee));

            Console.WriteLine(employeeList.GetType().Name);
            Console.WriteLine(employeeList.GetType().FullName);
            Console.WriteLine(employeeList.GetType().BaseType);

            /* Exploratory code

            closed constructed type: List<Employee>
            unbounded generic which is used only with typeof operator: List<> (this has an arity of 1)
            example of unbounded generic that takes two parameters: Dictionary<,>
            
            var employeeList = Activator.CreateInstance(typeof(List<Employee>));



            var genericArgs = employeeList.GetType().GetGenericArguments();
            foreach (var arg in genericArgs)
            {
                Console.WriteLine(arg.Name);
            }
            
            */

        }


        private static object CreateCollection(Type collectionType, Type itemType)
        {
            var closedType = collectionType.MakeGenericType(itemType);
            return Activator.CreateInstance(closedType);

        }
    }

    public class Employee
    {
        public string Name { get; set; }

    }

}
