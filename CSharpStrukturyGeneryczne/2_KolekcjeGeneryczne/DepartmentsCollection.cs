using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class DepartmentsCollection : SortedDictionary<string, SortedSet<Worker>>
    {
        public DepartmentsCollection Add(string departmentName, Worker worker)
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Worker>(new WorkerComparer()));
            }
            this[departmentName].Add(worker);
            return this;
        }
    }
}
++