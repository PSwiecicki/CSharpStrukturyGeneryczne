using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main()
        {
            var circularBuffer = new CircularBuffer(size: 3);

            double value;
            while (double.TryParse(Console.ReadLine(), out value))
            {
                circularBuffer.Add(value);
            }
            Console.WriteLine("W naszej kolejce są liczby: ");
            while(!circularBuffer.IsEmpty)
            {
                Console.WriteLine($"Wartość = { circularBuffer.Get() }");
            }
            Console.ReadKey();
        }
    }
}
