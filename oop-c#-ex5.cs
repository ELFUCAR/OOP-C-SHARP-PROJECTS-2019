/******************************************************************************

Guess the number

*******************************************************************************/
using System;
class Program
{

    public static int GuessTheNumber(int a, int b)
    {
        Random random = new Random();
        int steps = 0;
        int secretNumber = random.Next(a, b);
        bool notFound = true;

        int letItBe;
        while (notFound)
        {
            letItBe = (a + b) / 2;
            if (letItBe == secretNumber)
            { notFound = false; }

            if (secretNumber > letItBe)
            { a = letItBe; }
            else
            { b = letItBe; }
            steps++;
        } // while
        return steps;
    } // the end of GuessTheNumber


    static void Main()
    {

        int a = 0; int b = 1000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 2000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 10000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 100000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 1000000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        a = 0; b = 1000000000;
        Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b, GuessTheNumber(a, b));

        Console.ReadKey();

    }

}




