using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int secondDigit = int.Parse(grade[1].ToString());
        int gradePorcentage = int.Parse(grade);


        string letter = "";
        if (gradePorcentage >= 90)
        {
            letter = "A";
        }
        else if (gradePorcentage < 90 && gradePorcentage >= 80)
        {
            letter = "B";
        }
        else if (gradePorcentage < 80 && gradePorcentage >= 70)
        {
            letter = "C";
        }
        else if (gradePorcentage < 70 && gradePorcentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        string sign = "";
        if (secondDigit >= 7 && "BCD".Contains(letter))
        {
            sign = "+";
        }
        if (secondDigit < 3 && "ABCD".Contains(letter))
        {
            sign = "-";
        }

        string message = "Congratulations, you have passed the course!";
        if (gradePorcentage < 70)
        {
            message = "You need at least 70% to pass the course. Don't worry, you can try again with the knowledge you have already acquired.";
        }


        Console.WriteLine($"\n{message}");
        Console.WriteLine($"Your grade is {letter}{sign}\n");

    }
}