//namespace ConsoleApp1
//{
//    internal class BasicStack<T>
//    {
//        private readonly T[]? _items;
//        private int _currentIndex = -1;

//        public BasicStack() => _items = new T[10];

//        public int Count => _currentIndex + 1;

//        public void Push(T item)
//        {
//            if (_currentIndex + 1 == _items.Length)
//            {
//                throw new InvalidOperationException("Stack overflow");
//            }

//            _items[++_currentIndex] = item;
//        }

//        public T Pop()
//        {
//            if (_currentIndex == -1)
//            {
//                throw new InvalidOperationException("Stack is empty");
//            }

//            return _items[_currentIndex--];
//        }

//        public T Peek()
//        {
//            if (_currentIndex == -1)
//            {
//                throw new InvalidOperationException("Stack is empty");
//            }

//            return _items[_currentIndex];
//        }
//    }
//}
