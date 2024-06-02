using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Debugging
{
    internal class DebuggingVideo
    {
        public static void Run()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    DoSomething(counts, i);
                }
            }
        }

        private static void DoSomething(int[] counts, int i)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + counts[i]);
            }
        }
    }
}
