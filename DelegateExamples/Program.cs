using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    class Program
    {
        delegate double CalcAreaPtr(double r);
        static CalcAreaPtr caPtr = CalculateCircleArea;
        static double CalculateCircleArea(double r)
        {
            return 3.1415926 * r * r;
        }
        static void Main(string[] args)
        {
            // Func example
            Func<int, int, string> funcDelegate = (fn, sn) => "Sum = " + (fn + sn).ToString();
            string result = funcDelegate(10, 20);

            Console.WriteLine("FuncDelegate result: " + result);

            double area = caPtr.Invoke(10);

            // Or...
            CalcAreaPtr cPtr = r => 3.14 * r * r;
            area = cPtr(10);

            // Or ...
            Func<double, double> funcPtr = r => 3.14 * r * r;
            area = funcPtr(10);

            Action<string> myAction = y => Console.WriteLine(y);
            myAction("Hello from Action.");

            Console.ReadKey();
        }
    }
}
