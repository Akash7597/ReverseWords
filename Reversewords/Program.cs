using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversewords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string oldString = Console.ReadLine();
            StringBuilder reverseWordString = new StringBuilder();
            List<char> charlist = new List<char>();
            for (int i = 0; i < oldString.Length; i++)
            {
                if (oldString[i] == ' ' || i == oldString.Length - 1)
                {
                    if (i == oldString.Length - 1)
                    {
                        charlist.Add(oldString[i]);
                    }
                    for (int j = charlist.Count - 1; j >= 0; j--)
                    {
                        reverseWordString.Append(charlist[j]);
                    }
                    reverseWordString.Append(' ');
                    charlist = new List<char>();
                }
                else
                {
                    charlist.Add(oldString[i]);
                }
            }
            Console.WriteLine($"Reverse Word String : {reverseWordString.ToString()}");
            Console.ReadKey();

        }
    }
}
