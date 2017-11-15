using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hi", "LINQ", "curious", "Transformer", "why" };

            //LINQ to query short words

            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            // iterate through LINQ result set

            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
