using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main()
        {
            var circularBuffer = new CircularBuffer(size: 3);

            while (double.TryParse(Console.ReadLine(), out double value))
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
