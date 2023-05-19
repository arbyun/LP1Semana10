using System;
using System.Collections.Generic;

namespace StringCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the generic collections
            List<string> list = new List<string>();
            if (list == null) throw new ArgumentNullException(nameof(list));
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> hashSet = new HashSet<string>();
            if (hashSet == null) throw new ArgumentNullException(nameof(hashSet));

            // Inserting strings into each collection
            list.AddRange(new string[] { "string1", "string2", "string3", "string4", "string5" });
            stack.Push("string1");
            stack.Push("string2");
            stack.Push("string3");
            stack.Push("string4");
            stack.Push("string5");
            queue.Enqueue("string1");
            queue.Enqueue("string2");
            queue.Enqueue("string3");
            queue.Enqueue("string4");
            queue.Enqueue("string5");
            hashSet.Add("string1");
            hashSet.Add("string2");
            hashSet.Add("string3");
            hashSet.Add("string4");
            hashSet.Add("string5");


        }
    }
}
