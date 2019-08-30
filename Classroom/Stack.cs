using System;
using System.Collections;

namespace Classroom
{
    public class Stack
    {
        private ArrayList _stack;

        public Stack()
        {
            _stack = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                _stack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Cannot inject Null value into stack.");
            }
            
        }

        public object Pop()
        {
           
            if (_stack.Count > 0)
            {
                var length = _stack.Count;
                var obj = _stack[length - 1];
                _stack.Remove(obj);
                return obj;
            }
            else
            {

                throw new NullReferenceException();
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }


}


