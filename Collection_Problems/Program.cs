using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List();
            Stack();
            Queue();
        }
        public static void List()
        {
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(40);
            list.Add(20);
            list.Add(70);
            list.Add(90);
            Console.WriteLine("Values in List are: ");
            Console.WriteLine("-----------------------------------------------");
            foreach (var values in list)
            {
                Console.WriteLine(values);
            }
        }
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(500);
            stack.Push(400);
            stack.Push(200);
            stack.Push(700);
            stack.Push(900);
            int popvalue = stack.Pop();
            Console.WriteLine("Values in Stack are: ");
            Console.WriteLine("-----------------------------------------------");
            foreach (var values in stack)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine("Deleted value is: " + popvalue);
        }
        public static void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(500);
            queue.Enqueue(400);
            queue.Enqueue(200);
            queue.Enqueue(700);
            queue.Enqueue(900);
            int peekvalue = queue.Peek();
            int dequeuevalue = queue.Dequeue();
            Console.WriteLine("Values in Queue are: ");
            Console.WriteLine("-----------------------------------------------");
            foreach (var values in queue)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine("Peek value is: " + peekvalue);
            Console.WriteLine("Dequeue value is: " + dequeuevalue);
        }
    }
}
