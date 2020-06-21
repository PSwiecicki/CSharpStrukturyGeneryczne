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
            #region Tablica
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
            #endregion

            #region List
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
            #endregion

            #region Queue
            //Do kolejki można dodawać dane tylko na końcu. 
            //Odczytać możemy tylko pierwszy element i go zostawić w kolejce lub "wyciągnać" z kolejki. 
            //Możemy też sprawdzić czy kolejka posiada jakiś element lub sprawdzić przez rzutowanie na tablicę jakie ma elementy.

            /*
            Queue<Worker> workers = new Queue<Worker>();
            workers.Enqueue(new Worker { Name = "Patryk", Surname = "Słowik" });
            workers.Enqueue(new Worker { Name = "Jacek", Surname = "Bocian" });
            workers.Enqueue(new Worker { Name = "Kamil", Surname = "Kruk" });
            workers.Enqueue(new Worker { Name = "Grzegorz", Surname = "Jastrząb" });
            Console.WriteLine("Queue: ");
            while (workers.Count != 0)
            {
                var worker = workers.Dequeue();
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}.");
            }*/
            #endregion

            #region Stack
            //Do stosu dane można dodawać tylko na końcu.
            //W przeciwieństwie do kolejki odczytywany jest ostatni element (LIFO).
            //Ogólnie można wykonać operacje jak na Queue
            /*
            Stack<Worker> workersStack = new Stack<Worker>();
            workersStack.Push(new Worker { Name = "Patryk", Surname = "Słowik" });
            workersStack.Push(new Worker { Name = "Jacek", Surname = "Bocian" });
            workersStack.Push(new Worker { Name = "Kamil", Surname = "Kruk" });
            workersStack.Push(new Worker { Name = "Grzegorz", Surname = "Jastrząb" });
            Console.WriteLine("Stack: ");
            while (workersStack.Count != 0)
            {
                var worker = workersStack.Pop();
                Console.WriteLine($"Pracownik: {worker.Surname} {worker.Name}.");
            }
            */
            #endregion

            #region HashSet
            //Hashset nie gwarantuje, ze dane w nim będą zapisane w takiej kolejności w jakiej wpisujemy. 
            //Nie dopuszcza też powielania obiektów. Po odczytaniu danych nie są usuwane ale można je samemu usuwać.
            //Daje możliwość prostego porównywania danych z dwóch HashSetów. Można też usuwać przy pomocy warunków. 
            /*
            var test = new Worker { Name = "Patryk", Surname = "Słowik" };
            HashSet<Worker> workersHashSet = new HashSet<Worker>();
            workersHashSet.Add(test);
            workersHashSet.Add(new Worker { Name = "Jacek", Surname = "Bocian" });
            workersHashSet.Add(new Worker { Name = "Kamil", Surname = "Kruk" });
            workersHashSet.Add(new Worker { Name = "Grzegorz", Surname = "Jastrząb" });
            workersHashSet.Add(test);
            Console.WriteLine("HashSet");
            foreach (var worker in workersHashSet)
            {
                Console.WriteLine($"Pracownik: {worker.Name} {worker.Surname}.");
            }
            */
            #endregion

            #region LinkedList
            //Lista składa się z "węzłów". Każdy wskazuje tylko na kolejny i poprzedni obiekt. 
            //Dodawanie do listy robi się przez wskazanie za lub przed którym elementem ma zostać umieszczony nowy element
            //Powoduje to zmianę wskaźników tylko w dwóch elementach tak, zeby teraz wskazywały na nowy element. 
            /*
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);                 //Dodajemy pierwszy element
            linkedList.AddFirst(2);                 //Dodajemy dwójkę przed trójką
            linkedList.AddLast(6);                  //Dodajemy 6 na końcu
            linkedList.AddLast(7);                  //Dodajemy 7 na końcu

            var node = linkedList.First;            //Pobieramy miejsce pierwszego elementu (2)
            linkedList.AddBefore(node, 1);          //Dodajemy 1 przed pierwszym elementem
            node = node.Next;                       //Przenosimy się do następnego elementu (3)
            linkedList.AddAfter(node, 4);           //Dodajemy za nim 4
            node = node.Next;                       //Przenosimy się do kolejnego elementu (4)
            node = node.Next;                       //Ponownie przenosimy się do kolejnego elementu (6)
            linkedList.AddBefore(node, 5);          //Dodajemy przed tym elementem liczbę 5 
            Console.WriteLine("LinkedList: ");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            #region Dictionary
            //Skłownik składa się z dwóch typów, które go opisują. Pierwszy określa uniwersalny klucz dla każdego elementu,
            //natomiast drugi wartość przypisaną do tego elementu. Przed dodaniem kolejnych elementów warto sprawdzić
            //czy klucz jest uniwersalny ponieważ próba dodania kolejnego elementu o tym samym kluczu może doprowadzić nas do błędu.
            /*
            var dictionary = new Dictionary<int, Worker>();
            dictionary.Add(0, new Worker() { Name = "Gracjan", Surname = "Kawka" });
            dictionary.Add(1, new Worker() { Name = "Patryk", Surname = "Bocian" });
            if(!dictionary.ContainsKey(2))
                dictionary.Add(2, new Worker() { Name = "Grzegorz", Surname = "Brzęczyszczykiewicz" });
            */
            #endregion

            #region SortedDictionary
            //Jak zwykły słownik ale elementy są sortowane dzięki czemu podczas użycia pętli foreach wyniki mamy wyświetlane w kolejności
            //alfabetycznej. 
            /*
            var sortedDictionary = new SortedDictionary<string, List<Worker>>();
            sortedDictionary.Add("Zarządzanie", new List<Worker>()
            {
                new Worker() { Name = "Jan", Surname = "Kowalski"},
                new Worker() { Name = "Krzysztof", Surname = "Kwiatek"}
            });
            sortedDictionary.Add("Informatyka", new List<Worker>()
            {
                new Worker() { Name = "Grzegorz", Surname = "Szarańcza"},
                new Worker() { Name = "Martyna", Surname = "Keks"},
                new Worker() { Name = "Karol", Surname = "Furek"},
                new Worker() { Name = "Andrzej", Surname = "Marszewszki"}
            });
            sortedDictionary.Add("Biologia", new List<Worker>()
            {
                new Worker() { Name = "Juanita", Surname = "Mednez"},
                new Worker() { Name = "Marzena", Surname = "Kukułek" },
                new Worker() { Name = "Igor", Surname = "Paprotka"}
            });

            foreach(var list in sortedDictionary)
            {
                Console.WriteLine($"Dział {list.Key} posiada {list.Value.Count} pracowników");
            }
            */
            #endregion

            #region SortedList
            //Tak samo jak w Dictionary czy SortedDictionary wymagany jest klucz. SortedList jest optymalizowana pod szybszą 
            //iteracje oraz mniejsze zużycie pamięci. SortedDictionary jest za to optymalizowany pod dodawanie, pobieranie 
            //czy przeszukiwanie danych.
            /*
            var sortedList = new SortedDictionary<string, List<Worker>>();
            sortedList.Add("Zarządzanie", new List<Worker>()
            {
                new Worker() { Name = "Jan", Surname = "Kowalski"},
                new Worker() { Name = "Krzysztof", Surname = "Kwiatek"}
            });
            sortedList.Add("Informatyka", new List<Worker>()
            {
                new Worker() { Name = "Grzegorz", Surname = "Szarańcza"},
                new Worker() { Name = "Martyna", Surname = "Keks"},
                new Worker() { Name = "Karol", Surname = "Furek"},
                new Worker() { Name = "Andrzej", Surname = "Marszewszki"}
            });
            sortedList.Add("Biologia", new List<Worker>()
            {
                new Worker() { Name = "Juanita", Surname = "Mednez"},
                new Worker() { Name = "Marzena", Surname = "Kukułek" },
                new Worker() { Name = "Igor", Surname = "Paprotka"}
            });
            */
            #endregion

            #region SortedSet
            //SortedSet pozwala na przechowywanie unikalnych wartosci. Po dodaniu wartości są one od razu sortowane. 
            /*
            var sortedSet = new SortedSet<int>();
            sortedSet.Add(13);
            sortedSet.Add(2);
            sortedSet.Add(51);
            sortedSet.Add(10);
            sortedSet.Add(5);
            Console.WriteLine($"Pierwsza wartość to {sortedSet.First()}");
            foreach( var item in sortedSet)
            {
                Console.WriteLine($"{item}");
            }
            */
            #endregion

            var workers = new DepartmentsCollection();

            workers.Add("Sprzedaż", new Worker { Surname = "Czapla" })
                   .Add("Sprzedaż", new Worker { Surname = "Bocian" })
                   .Add("Sprzedaż", new Worker { Surname = "Kruk" })
                   .Add("Sprzedaż", new Worker { Surname = "Czapla" });

            workers.Add("Księgowość", new Worker { Surname = "Nowak" })
                   .Add("Księgowość", new Worker { Surname = "Stewczak" })
                   .Add("Księgowość", new Worker { Surname = "Kołek" })
                   .Add("Księgowość", new Worker { Surname = "Marczak" })
                   .Add("Księgowość", new Worker { Surname = "Nowak" });

            foreach (var department in workers)
            {
                Console.WriteLine(department.Key);
                foreach (var worker in department.Value)
                {
                    Console.WriteLine($"\t{worker.Surname}");
                }
            }

            Console.ReadKey();
        }
    }
}
