using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        if (percent >= 90)
        {
            Console.WriteLine("You got an A in the class.");
        }
        else if (percent >= 80 )
        {
            Console.WriteLine("You got a B in the class.");

        }

        else if (percent >= 70 )
        {
             Console.WriteLine("You got a C in the class.");
        }
        
        else if (percent >= 60 )
        {
             Console.WriteLine("You got a D in the class.");
        }

        else
        {
            Console.WriteLine("You got a F in the class.");
        }

        if ( percent >= 70)
        {
            Console.WriteLine("Congrats you passed the class!");

        }
        else 
        {
            Console.WriteLine("You did not pass the class, try again next time!");
        }
       

    }
}