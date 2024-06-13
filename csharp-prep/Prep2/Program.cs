using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("whats your grade Percentage");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = " ";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        
        }
        else if (percent >=60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }


        if (percent >= 70)
        {
            Console.WriteLine("Cheers!! You Passed!");
        }

        else
        {
            Console.WriteLine("There is always a next time to do better!");

        }

        //adding a + or -

        if (letter != "F" && letter != "A")
        {
            int lastDigit = percent % 10;
            if (lastDigit >= 7)
            {
                letter += "+";
            }
            else if (lastDigit <3)
            {
                letter += "-";

            }



        }
        Console.WriteLine($"Your grade is: {letter}");

    }

}