using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class SinglyLinkedList<T>
    {
        public class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                this.Data = data;
            }

        }
        public Node? head = null;
        public Node? tail = null;
        public int intSize;
       
        public int Add(T item)
        {
            Node node = new (item);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            intSize++;
            return intSize;
        }

        public bool Remove(T item)
        {
            Node cNode = head;
            Node pNode = null;

            while (cNode !=null)
            {
                if (cNode.Data.Equals(item))
                {
                    if (pNode == null)
                    {
                        head = cNode.Next;
                        if (head == null)
                            tail = null;
                    }
                    else
                    {
                        pNode.Next = cNode.Next;
                        if (cNode.Next == null)
                            tail = pNode;
                    }
                            intSize--;
                            return true;
                }
                        pNode = cNode;
                     cNode=cNode.Next;
            }
                    return false;
        }

        public bool CheckIfItemExist(T item) 
        {
            Node currentNode = head;
            while (currentNode !=null)
            {
                if (currentNode.Data.Equals(item))
                {
                    return true;
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }


        public int Index(T item)
        {
            Node cNode = head;
            int value = 0;
            while (cNode is not null)
            {
                if (cNode.Data.Equals(item))

                    return value;
                cNode = cNode.Next;
                    
                    
                    value++;
            }
            return -1;
        }
    }
}
