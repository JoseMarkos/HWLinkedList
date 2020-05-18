using System;
using System.Collections.Generic;

namespace HWCovid19Symptoms {
    sealed class Printer 
    {
        public static void Print(LinkedList<string> list)
        {
            System.Console.WriteLine("Syntoms:");
            System.Console.WriteLine();

            IEnumerator<string> enumerator = list.GetEnumerator();

            for (int i = list.Count; i > 0; i--)
            {
                enumerator.MoveNext();
                System.Console.WriteLine(enumerator.Current);
            }
        }
    }
}



