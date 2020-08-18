using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main()
        {
            var circularBuffer = new CircularQueue<double>();
            AddDataToBuffer(circularBuffer);

            //Action to delegat który nic nie zwraca, i przyjmuje ilosć parametrów od 0 do 16.
            Action<double> print = x => Console.WriteLine(x);
            Action<bool> printBool = x => Console.WriteLine(x);
            Action<int, int, int, int, int, int, int, int> lambda = (a, b, c, d, e, f, g, h) => Console.WriteLine($"Ciag Bonifacego: {a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}");
            lambda(1, 1, 2, 3, 5, 8, 13, 21);

            //Func to delegat który zawsze ma jedną wartość wyjściową, oraz od 0 do 16 parametrów wejściowych.
            Func<double, double> powOf2 = x =>  x * x;
            Func<int, double, double> multiplication = (x, y) => x * y;
            print(powOf2(5));
            print(multiplication(3, 4));

            //Predicate to delegat, który przyjmuje zawsze jedną wartość i zwraca wartość logiczną.
            Predicate<double> isPositiveNum = x => x > 0;
            printBool(isPositiveNum(-5));

            //Converter przyjmuje jeden parametr na wejściu i zwraca inną wartość 
            Converter<double, DateTime> doubleToDateTime = d => new DateTime(2000,1,1).AddDays(d);
            var circularBufferToDateTime = circularBuffer.ItemTo(doubleToDateTime);

            //można skrócić, do:
            //var circularBufferToDateTime = circularBuffer.ItemTo(d => new DateTime(2000,1,1).AddDays(d));
            foreach (var item in circularBufferToDateTime)
            {
                Console.WriteLine(item);
            }

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
