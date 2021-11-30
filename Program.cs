using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> mName = new Employee<string>();
            mName.Things = "James ";

            Employee<int> mNum = new Employee<int>();
            mNum.Things = 30;

            Console.WriteLine(mName.Things + mNum.Things);

            Console.ReadLine();
        }
    }
}
