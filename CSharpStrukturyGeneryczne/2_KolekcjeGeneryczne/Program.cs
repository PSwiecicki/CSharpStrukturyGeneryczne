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
            //Wielkość tablicy sprawdzamy przez workers.Length;
            foreach (var worker in workers)
            {
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}");
            }
            */

            //Wielkość listy odczytujemy przez workers.Count;
            //Pojemność odczytujemy przez workers.Capacity;
            //Lista umożliwa dodawanie elementów, ale może zabierać dużo zasobów. Każde przekroczenie pojemności zwiększa ją dwukrotnie. 

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

            Console.ReadKey();
        }
    }
}
