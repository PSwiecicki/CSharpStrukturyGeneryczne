using System.Collections.Generic;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public interface IQueue<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }

        void Add(T value);
        T Get();
    }
}