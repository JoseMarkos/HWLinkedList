using System;

namespace HWCovid19Symptoms {
    sealed class Printer {
        public static void Print(LinkedList list)
        {
            unsafe {
                fixed (int* ptr = &list.Head.Data) {
                   
                }
                
            }
        }
    }
}



