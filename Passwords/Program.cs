using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        private static String[] words =
        {
            "about",
            "after",
            "again",
            "below",
            "could",
            "every",
            "first",
            "found",
            "great",
            "house",
            "large",
            "learn",
            "never",
            "other",
            "place",
            "plant",
            "point",
            "right",
            "small",
            "sound",
            "spell",
            "still",
            "study",
            "their",
            "there",
            "these",
            "thing",
            "think",
            "three",
            "water",
            "where",
            "which",
            "world",
            "would",
            "write"
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Program program = new Program();
                program.run();
            }
        }

        public void run()
        {
            Console.WriteLine("Tumbler 1");
            tumblers[0] = Console.ReadLine();
            printAll(candidateWords());
            Console.WriteLine("Tumbler 2");
            tumblers[1] = Console.ReadLine();
            printAll(candidateWords());
            Console.WriteLine("Tumbler 3");
            tumblers[2] = Console.ReadLine();
            printAll(candidateWords());
            Console.WriteLine("Tumbler 4");
            tumblers[3] = Console.ReadLine();
            printAll(candidateWords());
            Console.WriteLine("Tumbler 5");
            tumblers[4] = Console.ReadLine();
            printAll(candidateWords());
        }

        private String[] tumblers = new String[5];

        private String validateTumbler(int n, String s)
        {
            if (tumblers[n] != null && s != null)
            {
                if (!tumblers[n].Contains(s[n]))
                {
                    return null;
                }
            }
            return s;
        }

        private List<String> candidateWords()
        {
            List<String> result = new List<String>();
            foreach (String possibleWord in words)
            {
                String candidate = validateTumbler(0, possibleWord);
                candidate = validateTumbler(1, candidate);
                candidate = validateTumbler(2, candidate);
                candidate = validateTumbler(3, candidate);
                candidate = validateTumbler(4, candidate);
                if (candidate != null)
                {
                    result.Add(candidate);
                }
            }
            return result;
        }

        private void printAll(List<String> toPrint)
        {
            foreach (String w in toPrint)
            {
                Console.Write(w);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
