using System;
using AbstraçãoRPG.Class;

namespace AbstraçãoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard =  new Wizard("Jennica", 23, "White Wizard");


            
            Console.WriteLine(wizard.Attack(1)); 
            Console.WriteLine(wizard.Attack(10)); 
        }
    }
}
