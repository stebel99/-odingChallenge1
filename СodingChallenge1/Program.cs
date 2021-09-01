using System;
using System.Collections.Generic;
using System.Text;

namespace СodingChallenge1
{
    static class Program
    {
        static void Main()
        {
            const int node = 666;
            const int position = 9;
            
            LinkedList<int> list = CreateFilledLinkedList(10);
            ShowLinkedList(list);

            if (position > 1 && position < list.Count)
            {
                list.Insert(node, position);
            }
            ShowLinkedList(list);


            Console.ReadKey();
        }

        static LinkedList<int> CreateFilledLinkedList(int maxNumber)
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < maxNumber; i++)
            {
                list.AddLast(i);
            }

            return list;
        }

        static void ShowLinkedList(LinkedList<int> list)
        {
            int arrowSize = 3;

            StringBuilder output = new StringBuilder();

            foreach (int number in list)
            {
                output.AppendFormat($"{number} -> ");
            }

            output.Remove(output.Length - arrowSize, arrowSize);

            Console.WriteLine(output.ToString());
        }
    }
}