using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class WorkerComparer : IEqualityComparer<Worker>, IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            return string.Compare(x.Surname, y.Surname);
        }

        public bool Equals(Worker x, Worker y)
        {
            return string.Equals(x.Surname, y.Surname);
        }

        public int GetHashCode(Worker obj)
        {
            return obj.Surname.GetHashCode();
        }
    }
}
