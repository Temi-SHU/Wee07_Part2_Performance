// See https://aka.ms/new-console-template for more information


while (true)
{
    Direction direction = AskForDirection();

    Console.WriteLine("First WriteLine");

    if (direction == Direction.Left) GoLeft();
    else GoRight();

    Console.WriteLine("Second WriteLine");

    RestForAWhile();

    Console.WriteLine("Third WriteLine");

    break;

}

// A simple function that prompts the user 
Direction AskForDirection()
{
    while (true)
    {
        Console.Write("You will walk a 10 step, but in which direction, left (l) or right? (r): ");
        string input = Console.ReadLine()!;

        if (input.ToLower() == "left" || input.ToLower() == "l") return Direction.Left;
        if (input.ToLower() == "right" || input.ToLower() == "r") return Direction.Right;

        Console.WriteLine("\t\tThe valid inputs are 'left', 'l', 'right' or 'r'\n\t\tPress any key to try again.\n\n");
        Console.ReadKey();
        Console.Clear();
    }
}

void RestForAWhile()
{
    for(int i = 0; i <= 20; i++)
    {
        Console.Clear();
        Console.WriteLine($"Rested for {i} sec.");
        Thread.Sleep(1000);
    }
}

void GoLeft()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Clear();
        Console.WriteLine($"Walked {i} step to the left.");
        Thread.Sleep(1000);
    }
}

void GoRight()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Clear();
        Console.WriteLine($"Walked {i} step to the right.");
        Thread.Sleep(1000);
    }
}
enum Direction
{
    Left,
    Right
}