using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80 )
        {
            letter = "B";

        }

        else if (percent >= 70 )
        {
            letter = "C";
        }
        
        else if (percent >= 60 )
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}. ");

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