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
                queue.Dequeue();
        }

        public override bool IsFull
        {
            get
            {
                return queue.Count == _size;
            }
        }
    }
}
