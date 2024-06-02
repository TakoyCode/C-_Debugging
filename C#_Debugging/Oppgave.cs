using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Debugging
{
    internal class Oppgave
    {
        public static void Run()
        {
            var range = 250;

            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                // Verdien til character er ingen ting når den først treffer foreach løkken.
                // Men etter at foreach løkken kjører en gang så blir character = 'H';
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                // i må være 250 for at den skal treffe breakpointet på slutten av while løkken.
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                    }
                }
            }
        }
    }
}
