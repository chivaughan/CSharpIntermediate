using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Stack
    {
        private List<object> _stack;
        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
            _stack.Add(obj);
        }

        public Object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException();
            var removedItem = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return removedItem;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
