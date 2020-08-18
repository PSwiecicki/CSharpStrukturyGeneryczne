using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Runtime.InteropServices;
using System.Linq;

namespace _4_MetodyDelegatyGeneryczne
{ 
    public static class QueueExtenstions
    {
        public static IEnumerable<Tout> ItemTo<T, Tout>(this IQueue<T> queue, Converter<T, Tout> converter)
        {
            /*foreach (var item in queue)
            {
                var wynik = converter(item);
                yield return wynik;
            }*/
            //Można skrócić do: 
            return queue.Select(item => converter(item));
            //Jest to metoda z Linq, o czym później muszę doczytać
        }
        
        public static void Print<T>(this IQueue<T> queue, Action<T> print)
        {
            foreach (var item in queue)
                print(item);
        }
    }
}
