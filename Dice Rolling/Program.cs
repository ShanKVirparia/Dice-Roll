
Console.WriteLine("Welcome to Lady Luck Casino!");
Console.WriteLine("Lets play some craps!");

Console.WriteLine("Here we get choose the number of sides you would like to roll. How many sides?");
int diceSides = Convert.ToInt32(Console.ReadLine());

if (diceSides != 6)
{
    Console.WriteLine("We don't have dice with that many sides.");
    Console.ReadKey();
    
}
else if (diceSides == 6)
{
    while (true)
    {
        GenerateDiceNumbers(diceSides);

        Console.WriteLine("Do you want to play again? (Yes or No)");
        string answer = Convert.ToString(Console.ReadLine());

        if (answer.ToLower().Trim() == "yes")
        {
            continue;
        }
        else
        {
            break;
        }
    }
}

void GenerateDiceNumbers(int choosenDiceSides)
{
    Random random = new Random();
    int diceOne = random.Next(1, choosenDiceSides + 1);
    int diceTwo = random.Next(1, choosenDiceSides + 1);
    
    GenerateDiceTotal(diceOne, diceTwo);
}

static int GenerateDiceTotal(int diceOne, int diceTwo)
{
    
    Console.WriteLine("Roll!");
    int totalValueOfDice = diceOne + diceTwo;
    Console.WriteLine($"You rolled {totalValueOfDice}");

    if (totalValueOfDice == 2)
    {
        Console.WriteLine("You got bitten by the Snake!");

    }
    else if (totalValueOfDice == 3)
    {
        Console.WriteLine("Ace-y Deuce-y!");
    }
    else if (totalValueOfDice == 12)
    {
        Console.WriteLine("Choo, Choo, Boxcars!");
    }
    else if (totalValueOfDice == 7 || totalValueOfDice == 11)
    {
        Console.WriteLine("Winner Winner Chicken Dinner!!!");
    }
    else
    {
        Console.WriteLine("");
    }
    return totalValueOfDice;
    
}    





