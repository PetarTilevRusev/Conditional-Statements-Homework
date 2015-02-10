using System;
/*Problem 2. Bonus Score

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is 0 or more than 9, the program prints “invalid score”.

                Examples:
                score 	result
                2 	    20
                4 	    400
                9 	    9000
                -1 	    invalid score
                10 	    invalid score
 */
class BonusScore
{
    static void Main()
    {
        start:
        Console.WriteLine("Enter your score below!");
        Console.Write("Your score: ");
        int userScore = int.Parse(Console.ReadLine());

        if (userScore >= 1 && userScore <= 3)
        {
            int finalScore = userScore * 10;
            Console.WriteLine("Your score is: {0}", finalScore);
        }
        else if (userScore >= 4 && userScore <= 6)
        {
            int finalScore = userScore * 100;
            Console.WriteLine("Your score is: {0}", finalScore);
        }
        else if (userScore >= 7 && userScore <= 9)
        {
            int finalScore = userScore * 1000;
            Console.WriteLine("Your score is: {0}", finalScore);
        }
        else
        {
            Console.WriteLine("Invalid score!");
            goto start; //I know it's bad practice to use it, but I want to try it!
        }
    }
}

