using System;
                /*Problem 4. Multiplication Sign
                
                    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
                        Use a sequence of if operators.
                
                            Examples:
                            a 	    b 	    c 	    result
                            5 	    2 	    2 	    +
                            -2 	    -2 	    1 	    +
                            -2 	    4 	    3 	    -
                            0 	    -2.5 	4 	    0
                            -1 	    -0.5 	-5.1 	-
                 */
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers below!");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The result is 0 !");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The result is - !");
        }
        else if ()
        {
            
        }
        else if (firstNumber < 0 && secondNumber < 0)
        {
            Console.WriteLine("The result is + !");
        }
        else if (firstNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The result is + !");
        }
        else if (secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The result is + !");
        }
        else
        {
            Console.WriteLine("The result is + !");
        }

    }
}

