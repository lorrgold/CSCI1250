//Part 1:  The Menu
int choice = 0;
int score = 0;
//do
//{
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
Console.Write("Chose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());
//while: has to run multiple times
while (choice > 5)
{
    System.Console.WriteLine("Choose a number from 1 to 5.");
    Console.Write("Chose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

//
if (choice == 1 || choice == 4)
{
// Exercise 1
System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
Console.Write("Score: ");
score = Convert.ToInt32(Console.ReadLine());
//
while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100");
        Console.Write("Score: ");
    score = Convert.ToInt32(Console.ReadLine());
    }
//
if (score >= 90)
    {
        System.Console.WriteLine($"{score} earns an A.");
    }
//
else if (score >= 80)
    {
        System.Console.WriteLine($"{score} earns a B.");
    }
//
else if (score >= 70)
    {
        System.Console.WriteLine($"{score} earns a C.");
    }
//
else if (score >= 60)
    {
        System.Console.WriteLine($"{score} earns a D.");
    }
//
else if (score <= 59)
    {
        System.Console.WriteLine($"{score} earns a F.");
    }
}

//
if (choice == 2 || choice == 4)
{
// Exercise 2
System.Console.WriteLine("2");
}

//
if (choice == 3 || choice == 4)
{
// Exercise 3
System.Console.WriteLine("3");
}
//} while (choice !=5);

//Console.WriteLine("Goodbye.");

