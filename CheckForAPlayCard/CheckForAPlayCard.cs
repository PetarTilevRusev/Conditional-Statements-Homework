using System;
                /*Problem 3. Check for a Play Card
                
                    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
                     Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
                
                            character 	Valid card sign?
                            5 	            yes
                            1 	            no
                            Q 	            yes
                            q 	            no
                            P 	            no
                            10 	            yes
                            500 	        no
                */
class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter a character and I will check is it a play card or not");
        Console.WriteLine("Your character: ");
        string userImput = Console.ReadLine();

        switch (userImput)
        {
            case "2":
                Console.WriteLine("Yes your character is a play card number");
                break;
            case "3":
                Console.WriteLine("Yes your character is a play card number");
                break;
            case "4":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "5":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "6":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "7":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "8":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "9":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "10":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "J":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "Q":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "K":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            case "A":
                Console.WriteLine("Yes, your character is a play card number");
                break;
            default:
                Console.WriteLine("No, your character is not a play card");
                break;
        }
    }
}

