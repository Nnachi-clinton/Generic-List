using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Queue <T>
    {
        public SinglyLinkedList<T> queue;

        public Queue()
        {
            queue = new SinglyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            return queue.intSize == 0;
        }

        public void Enqueue(T item)
        {
            queue.Add(item);
        }
        public T Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("invalid item");

            T item = queue.head.Data;
            queue.Remove(item);
            return item;
        }
        
        public int Size()
        {
            return queue.intSize;
        }
    }
}
