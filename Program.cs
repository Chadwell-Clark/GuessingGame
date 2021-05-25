using System;

Console.WriteLine("Can you Guess the Secret Number??? ");
Console.Write("");
string response = Console.ReadLine();
// Console.WriteLine(response);
string secretNumber = "42";

Compare();

void Compare()
{
    if (response == secretNumber)
    {
        Console.WriteLine("You guessed correctly!");
    }
    else
    {
        Console.WriteLine("You failed!");
    }
}