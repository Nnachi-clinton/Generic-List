namespace GenericsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> singlyLinkedList = new();
            Console.WriteLine("<==== showing details for singlyLinkedList linked list ====>");
           
            singlyLinkedList.Add(1);
            singlyLinkedList.Add(2);
            Console.WriteLine(singlyLinkedList.Add(6));
            Console.WriteLine(singlyLinkedList.Remove(8));
            Console.WriteLine(singlyLinkedList.CheckIfItemExist(1));
            Console.WriteLine(singlyLinkedList.Index(6));

            Console.WriteLine("<==== showing details for stack list ====>");
            Stack<int> stack = new();
            Console.WriteLine(stack.IsEmpty());
            stack.Push(35);
            stack.Push(14);
            stack.Push(34);

            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Size());



            Console.WriteLine("<==== showing details for queue list ====>");

            Queue <int> queue = new();
            Console.WriteLine(queue.IsEmpty()); // checks if the queue is empty
            queue.Enqueue(1);// Adds item to the queue
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.Dequeue()); //Removes item from the head of the queue
            Console.WriteLine(queue.Size());//checks the total size of the queue
        }
}
}