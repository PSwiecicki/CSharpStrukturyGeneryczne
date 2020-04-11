namespace _1_TypyGeneryczne
{
    public class CircularQueue
    {
        private double[] _buffer;
        private int _startOfBuffer;
        private int _endOfBuffer;

        public int BufferSize {
            get {
                return _buffer.Length;
            }
        }

        public bool IsEmpty {
            get {
                return _startOfBuffer == _endOfBuffer;
            }
        }

        public bool IsFull{
            get {
                return (_endOfBuffer + 1) % BufferSize == _startOfBuffer;
            }
        }

        public CircularQueue() : this(size: 5)
        {

        }

        public CircularQueue(int size)
        {
            _buffer = new double[size];
            _startOfBuffer = 0;
            _endOfBuffer = 0;
        }

        public void Add(double value)
        {
            _buffer[_endOfBuffer] = value;
            _endOfBuffer = (_endOfBuffer + 1) % BufferSize;

            if(_endOfBuffer == _startOfBuffer)
            {
                _startOfBuffer = (_startOfBuffer + 1) % BufferSize;
            }
        }

        public double Get()
        {
            var value = _buffer[_startOfBuffer];
            _startOfBuffer = (_startOfBuffer + 1) % BufferSize;
            return value;
        }
    }
}
