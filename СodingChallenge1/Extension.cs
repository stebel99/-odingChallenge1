using System.Collections.Generic;

namespace СodingChallenge1
{
    public static class Extension
    {
        public static LinkedList<int> Insert(this LinkedList<int> list, int node, int position)
        {
            int first = list.First.Value;
            list.RemoveFirst();

            if (position == 1)
            {
                list.AddFirst(first);
                list.AddFirst(node);
            }
            else
            {
                list.Insert(node, position - 1);
                list.AddFirst(first);
            }

            return list;
        }
    }
}