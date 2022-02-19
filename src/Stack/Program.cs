// See https://aka.ms/new-console-template for more information
using System;
namespace StackTask
{
    class Student{
        public String Name{get; set;}=" ";
        public int Id{get;set;}
        public Student(string name, int id){
            Name=name;
            Id=id;
        }
        public override string ToString()
        {
            return $"{Name} is a student with {Id} as an ID";
        }
    }
    
    class Program
    {
        internal static void Main(string[] Args)
        {
            
            Stack<int> st1 = new Stack<int>();
            Stack <char> st2= new Stack<char>();
            Stack<Student> st3=new Stack<Student>();
            
            // st1.Pop() throw ""THe stack is Empty"" exception
            Console.WriteLine("Stack of integer");
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);
            st1.Print();

            var s1=st1.Peak();
            Console.WriteLine($"The Top of the stack is {s1}");

            var s = st1.Pop();
             Console.WriteLine("The stack after one Pop: ");
            st1.Print();
            st1.Clear();
            Console.WriteLine("The stack after cleaning it: ");
            st1.Print();
            st1.Push(11);
             Console.WriteLine("The stack after cleaning it and push to it: ");
             st1.Print();


            Console.WriteLine("Stack of character");
            st2.Push('A');
            st2.Push('z');
            st2.Print();

            Console.WriteLine("Stack of Student");
            st3.Push(new Student("X1",117));
            st3.Push(new Student("X2",118));
            st3.Print();




        }

    }
}