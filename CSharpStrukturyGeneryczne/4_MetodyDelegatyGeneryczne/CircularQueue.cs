using System;

namespace _4_MetodyDelegatyGeneryczne
{
    public class CircularQueue<T> : BigQueue<T>
    {
        private int _size;
        public CircularQueue(int size = 5)
        {
            _size = size;
        }

        public override void Add(T value)
        {
            base.Add(value);
            if (queue.Count > _size)
            {
                var removed = queue.Dequeue();
                AfterRemove(removed, value);
            }

        }

        private void AfterRemove(T removed, T value)
        {
            if(removed != null)
            {
                var args = new ItemRemovedEventArgs<T>(removed, value);
                itemRemoved(this, args);
            }
        }

        public override bool IsFull
        {
            get
            {
                return queue.Count == _size;
            }
        }

        public event EventHandler<ItemRemovedEventArgs<T>> itemRemoved;
    
    }

}
