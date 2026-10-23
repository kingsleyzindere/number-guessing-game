//Random Number Generator
// Guess a random number between 1 and 100.
Random random = new Random();
int secretNumber = random.Next(1, 101);
int number;
int attempts = 0;

do
{
    Console.WriteLine("Please guess a number between 1 and 100:");
    bool isNumber = int.TryParse(Console.ReadLine(), out number);

    if (!isNumber)
    {
        Console.WriteLine("Please enter a valid whole number.");
    }
    else if (number < 1 || number > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
    }
    else
    {
        attempts++;
        Console.WriteLine($"Your guessed number is {number}.");

        if (number == secretNumber)
        {
            Console.WriteLine("Correct guess!");
        }
        else if (number > secretNumber)
        {
            Console.WriteLine("Too high, try again.");
        }
        else
        {
            Console.WriteLine("Too low, try again.");
        }
    }
}
while (number != secretNumber);

Console.WriteLine($"You took {attempts} attempts.");