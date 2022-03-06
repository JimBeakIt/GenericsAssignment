using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> Name = new Employee<string>();


            Name.Things = new List<string>()
            {
                "James",
                "Peter",
                "Lisa",
                "Fred"
            };


            Employee<int> Num = new Employee<int>();

            Num.Things = new List<int>()
            {
                27,
                72,
                30,
                34
            };

            Name.Things.ForEach(Console.WriteLine);

            Num.Things.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
