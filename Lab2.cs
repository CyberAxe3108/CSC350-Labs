Console.WriteLine("Enter two numbers: ");
String input1 = Console.ReadLine();
String input2 = Console.ReadLine();
Random rand = new Random();
int num1 = rand.Next(int.Parse(input1), int.Parse(input2));
Console.WriteLine("Guess the number between " + input1 + " and " + input2);
int guess = int.Parse(Console.ReadLine());
while (guess != num1)
{
    if (guess < num1)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Too high! Try again.");
    }
    guess = int.Parse(Console.ReadLine());
}
