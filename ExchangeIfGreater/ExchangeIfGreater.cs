using System;
/*Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

            Examples:
            a 	    b 	    result
            5 	    2 	    2 5
            3 	    4 	    3 4
            5.5     4.5 	4.5 5.5
 */
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers!");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber) // if the first number is bigger then second number, I exchange their values
        {
            double tempValue = firstNumber; //Making new temp value to hold the first number value
            firstNumber = secondNumber;
            secondNumber = tempValue;
            Console.WriteLine("First number = {0} \nSecond number = {1}\n{0} {1}", firstNumber, secondNumber );
        }
        else if (secondNumber > firstNumber)
        {
            Console.WriteLine("{0} > {1}", secondNumber, firstNumber);
        }
        else if (firstNumber == secondNumber)
        {
            Console.WriteLine("The numbers are equal!");
        }
    }
}

