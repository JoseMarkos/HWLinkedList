using System;

namespace HWCovid19Symptoms
{
    public unsafe class Node
    {
        public int Data;

        private int* Next;

        public Node(int data) {
            Data = data;
        }
    }
}
