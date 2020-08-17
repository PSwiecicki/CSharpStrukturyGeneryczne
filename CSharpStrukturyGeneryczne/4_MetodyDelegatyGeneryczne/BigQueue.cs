using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace _4_MetodyDelegatyGeneryczne
{
    public  class BigQueue<T> : IQueue<T>
    {
        protected Queue<T> queue;

        public BigQueue()
        {
            queue = new Queue<T>();
        }

        public virtual bool IsEmpty
        {
            get
            {
                return queue.Count == 0;
            }
        }
        public virtual bool IsFull
        {
            get
            {
                return false;
            }
        }

        public virtual void Add(T value)
        {
            queue.Enqueue(value);
        }

        public virtual T Get()
        {
            return queue.Dequeue();
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return queue.GetEnumerator();
            foreach(var item in queue)
            {
                yield return item;
                //yield return zwraca pojedyńczo elementy (Mozna wtedy zastosować jakieś filtrowanie do wyświetlanych wyników)
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
