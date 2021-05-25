using System;


string response;
string secretNumber = "42";
int counter = 0;


GuessingGame();




void Compare()
{
    if (response == secretNumber)
    {
        Console.WriteLine("You guessed correctly!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine($"Incorrect Guess!({counter})");
    }
}

void AskQuestion()
{
    Console.WriteLine("Can you Guess the Secret Number??? ");
    Console.Write("");
    response = Console.ReadLine();
}

void Loop()
{
    for (int i = 1; i <= 4; i++)
    {
        counter++;
        AskQuestion();
        Compare();
    }

}

void GuessingGame()
{
    Loop();
}

