using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main()
        {

            //Zwykła tablica, nie generyczna. Brak możliwości dodawania elementów poza określony przy inicializacji rozmiar. 
            //Jak chcemy powiekszyć musimy wygenerować i skopiować już zapisane wartości do nowej (większej) tablicy. 
            /*
            Worker[] workers = new Worker[]
            {
                new Worker { Name = "Patryk", Surname = "Święcicki" },
                new Worker { Name = "Jan", Surname = "Kowalski" },
                new Worker { Name = "Grzegorz", Surname = "Brzęczyszczykiewicz" },
            };
            foreach (var worker in workers)
            {
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}");
            }
            */

            //Lista umożliwa dodawanie elementów, ale może zabierać dużo zasobów. 
            //Każde przekroczenie pojemności zwiększa ją dwukrotnie. 
            //Możliwe jest usuwanie kpnkretnych elementów lub na wyznaczonych pozycjach 
            //oraz sprawdzanie czy dany obiekt jest już na liście. 
            /*
            List<Worker> workers = new List<Worker>()
            {
                new Worker { Name = "Patryk", Surname = "Święcicki" },
                new Worker { Name = "Jan", Surname = "Kowalski" },
                new Worker { Name = "Grzegorz", Surname = "Brzęczyszczykiewicz" },
            };
            

            foreach (var worker in workers)
            {
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}");
            }
            */

            //Queue
            Queue<Worker> workers = new Queue<Worker>();
            workers.Enqueue(new Worker { Name = "Patryk", Surname = "Słowik" });
            workers.Enqueue(new Worker { Name = "Jacek", Surname = "Bocian" });
            workers.Enqueue(new Worker { Name = "Kamil", Surname = "Kruk" });
            workers.Enqueue(new Worker { Name = "Grzegorz", Surname = "Jastrząb" });

            while (workers.Count != 0)
            {
                var worker = workers.Dequeue();
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}.");
            }

            Console.ReadKey();
        }
    }
}
