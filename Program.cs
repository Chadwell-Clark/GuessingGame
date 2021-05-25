using System;


string response;
string secretNumber;
int counter = 0;
int difficulty = 0;


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
        GuessStatement();
    }
}

void GuessStatement()
{
    if (difficulty == 0)
    {
        Console.WriteLine("You have unlimited guesses left");
        UnlimitedLoop();
    }
    else
    {
        Console.WriteLine($"You have {difficulty - counter} guesses left");
        if ((difficulty - counter) == 0)
            Console.WriteLine($"The Secret Number was {secretNumber}");
    }
}

void AskQuestion()
{
    Console.WriteLine("Guess a number between 1 and 100???");
    Console.Write("");
    response = Console.ReadLine();
    int responseInt;
    var isNumeric = int.TryParse(response, out responseInt);
    if (!(responseInt > 0 && responseInt <= 100) || (isNumeric == false))
    {
        AskQuestion();
    }
}

void Loop()
{
    for (int i = 1; i <= difficulty; i++)
    {
        counter++;
        AskQuestion();
        Compare();
    }

}

void UnlimitedLoop()
{
    AskQuestion();
    while (!(Int32.Parse(response) == Int32.Parse(secretNumber)))
    {
        Compare();
    }
}

void DifficultyLevel()
{
    Console.WriteLine("Choose a difficulty level... Easy, Medium , Hard or Cheater");
    string level = Console.ReadLine();
    if (level.ToLower() != "easy"
    && level.ToLower() != "medium"
    && level.ToLower() != "hard"
    && level.ToLower() != "cheater"
    )
    {
        Console.WriteLine("Please choose a difficulty level of Easy, Medium , Hard or Cheater");
        DifficultyLevel();
    }
    else if (level.ToLower() == "easy")
    {
        difficulty = 8;
    }
    else if (level.ToLower() == "medium")
    {
        difficulty = 6;
    }
    else if (level.ToLower() == "hard")
    {
        difficulty = 4;
    }
    else if (level.ToLower() == "cheater")
    {
        difficulty = 0;
    }
}

void Hint()
{
    if (Int32.Parse(response) > Int32.Parse(secretNumber))
    {
        Console.WriteLine("Too High!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Too Low");
        Console.WriteLine();
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
    DifficultyLevel();
    RandomNumber();
    if (difficulty == 0)
    {
        UnlimitedLoop();
    }
    else
    {
        Loop();
    }
}

