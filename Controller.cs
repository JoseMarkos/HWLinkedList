using System;
using System.Collections.Generic;

namespace HWCovid19Symptoms {
    sealed class Controller 
    {
        public static void Show()
        {
            LinkedList<string> Covid19Symptoms = new LinkedList<string>();

            Covid19Symptoms.AddFirst("Cough");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "Shortness of breath or difficulty breathing");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "Fever");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "Chills");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "Muscle pain");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "Sore throat");
            Covid19Symptoms.AddAfter(Covid19Symptoms.First, "New loss of taste or smell");

            Printer.Print(Covid19Symptoms);

            System.Console.WriteLine("\nPossible treatment: https://www.youtube.com/watch?v=9eAKPGnaFY8");

        }
    }
}



