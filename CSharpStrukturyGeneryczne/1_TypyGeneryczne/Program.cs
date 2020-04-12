using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main()
        {
            var circularBuffer = new CircularBuffer<double>(size: 3);
            AddDataToBuffer(circularBuffer);
            ReadDataFromBuffer(circularBuffer);
        }

        private static void ReadDataFromBuffer(CircularBuffer<double> circularBuffer)
        {
            while (!circularBuffer.IsEmpty)
            {
                Console.WriteLine($"Wartość = { circularBuffer.Get() }");
            }
            Console.ReadKey();
        }

        private static void AddDataToBuffer(CircularBuffer<double> circularBuffer)
        {
            Console.WriteLine("Podaj liczby do bufora: ");
            while (double.TryParse(Console.ReadLine(), out double value))
            {
                circularBuffer.Add(value);
            }
            Console.WriteLine("W naszej kolejce są liczby: ");
        }
    }
}
