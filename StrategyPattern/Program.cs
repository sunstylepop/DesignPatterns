using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>策略模式</summary>
    class Program
    {

        static void Main(string[] args)
        {
            var MyCar = new Car();
            Console.WriteLine(MyCar.EngineName);

            MyCar.SetEngine(new JetEngine());
            Console.WriteLine(MyCar.EngineName);

            Console.ReadLine();
        }
    }
}
