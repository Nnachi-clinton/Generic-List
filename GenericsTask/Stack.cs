using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Stack <T>
    {
        public SinglyLinkedList<T> stack;

        public Stack()
        {
            stack = new SinglyLinkedList <T>();
        }

        public bool IsEmpty()
        {
            return stack.intSize == 0;
        }

        public void Push(T item)
        {
            stack.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Empty item");

            T item = stack.tail.Data;
               stack.Remove(item);            
                return item;
        }
        public T Peek() 
        {
            if (IsEmpty())
                Console.WriteLine("Empty item");

            return stack.tail.Data;        
        }

        public int Size()
        {
            return stack.intSize;
        }
    }
}
