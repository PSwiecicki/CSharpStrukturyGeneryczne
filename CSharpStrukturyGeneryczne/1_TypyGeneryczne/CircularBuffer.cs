namespace _1_TypyGeneryczne
{
    public class CircularBuffer
    {
        private double[] _Buffer;
        private int _StartOfBuffer;
        private int _EndOfBuffer;

        public CircularBuffer() : this(size: 5)
        {

        }

        public CircularBuffer(int size)
        {
            _Buffer = new double[size];
            _StartOfBuffer = 0;
            _EndOfBuffer = 0;
            IsEmpty = true;
            IsFull = false;
        }

        public int BufferSize {
            get {
                return _Buffer.Length;
            }
        }

        public bool IsEmpty { get; set; }

        public bool IsFull { get; set; }

        public void Add(double value)
        {

            if ((_EndOfBuffer == _StartOfBuffer) && !IsEmpty)
            {
                _StartOfBuffer = (_StartOfBuffer + 1) % BufferSize;
            }
            IsEmpty = false;
            _Buffer[_EndOfBuffer] = value;
            _EndOfBuffer = (_EndOfBuffer + 1) % BufferSize;
            if((_EndOfBuffer == _StartOfBuffer) && !IsEmpty)
            {
                IsFull = true;
            }
        }

        public double Get()
        {
            if (IsEmpty)
                return 0.0;
            IsFull = false;
            var value = _Buffer[_StartOfBuffer];
            _StartOfBuffer = (_StartOfBuffer + 1) % BufferSize;
            if (_EndOfBuffer == _StartOfBuffer)
                IsEmpty = true;
            return value;
        }
    }
}
