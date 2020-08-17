using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Runtime.InteropServices;

namespace _4_MetodyDelegatyGeneryczne
{
    public delegate void Printer<T>(T data);

    public static class QueueExtenstions
    {
        public static IEnumerable<Tout> ItemTo<T, Tout>(this IQueue<T> queue)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in queue)
            {
                var wynik = converter.ConvertTo(item, typeof(Tout));
                yield return (Tout)wynik;
            }
        }
        
        public static void Print<T>(this IQueue<T> queue, Action<T> print)
        {
            foreach (var item in queue)
                print(item);
        }
    }
}
