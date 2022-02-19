// See https://aka.ms/new-console-template for more information
using System;
namespace StackTask
{
    class Program
    {
        internal static void Main(string[] Args)
        {
            Stack<int> st1 = new Stack<int>();
            st1.Print();
            st1.Push(2);
            st1.Print();
            st1.Push(3);
            st1.Push(4);
            st1.Print();
            var s = st1.Pop();
            st1.Print();
            s = st1.Pop();
            st1.Print();
            s = st1.Pop();
            st1.Print();

        }

    }
}