using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void CW<T>(T data)
        {
            Console.WriteLine(data);
        }

        static void Main()
        {
            Action<double> print = CW;


            var circularBuffer = new CircularQueue<double>();
            AddDataToBuffer(circularBuffer);

            //var circularBufferToInt = circularBuffer.ItemTo<double, int>();


            circularBuffer.Print(print);

            ReadDataFromBuffer(circularBuffer);
        }

        private static void ReadDataFromBuffer(IQueue<double> buffer)
        {
            while (!buffer.IsEmpty)
            {
                Console.WriteLine($"Wartość = { buffer.Get() }");
            }
            Console.ReadKey();
        }

        private static void AddDataToBuffer(IQueue<double> buffer)
        {
            Console.WriteLine("Podaj liczby do bufora: ");
            while (double.TryParse(Console.ReadLine(), out double value))
            {
                buffer.Add(value);
            }
            Console.WriteLine("W naszej kolejce są liczby: ");
        }
    }
}
