using System;
using System.Collections.Generic;
using System.Text;
using CollectionExample;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCharacterReader r = new SimpleCharacterReader();
            try
            {
                while (true)
                {
                    r.GetNextChar();
                }
            }
            catch (Exception e)
            {
                // ignore this exception
            }

            List<Node<string, int>> list = r.GetWordList();

            foreach (Node<string, int> n in list)
            {
                System.Console.Write(n);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Sorted by frequency...");
            list.Sort(new AlternativeComparator<string, int>());
            foreach (Node<string, int> n in list)
            {
                System.Console.Write(n);
            }
        }
    }
}
