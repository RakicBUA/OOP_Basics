using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mensch = new Human();// erstellung eines Objektes mit dem Typen Human wird auf dem HEAP abgelegt
            Mensch.Age = 99;// Auch im Heap 
           
            Console.WriteLine(Mensch.Age);
            Console.WriteLine(Mensch.speak());
        }
    }
}
