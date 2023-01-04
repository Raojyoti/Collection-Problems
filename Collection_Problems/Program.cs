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
    }
}
