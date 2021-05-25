using System;


string response;
string secretNumber;
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
        Hint();
        Console.WriteLine($"You have {4 - counter} guesses left");
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


void Hint()
{
    if (Int32.Parse(response) > Int32.Parse(secretNumber))
    {
        Console.WriteLine("Too High!");
    }
    else
    {
        Console.WriteLine("Too Low");
    }
}
void RandomNumber()
{
    Random num = new Random();
    int randomNum = num.Next(1, 100);
    secretNumber = randomNum.ToString();
}

void GuessingGame()
{
    RandomNumber();
    Loop();
}

