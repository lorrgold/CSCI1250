
Random rng = new Random (4000);
int choice = 0;
int score = 0;
int roll1 = 0;
int roll2 = 0;
string rollAgain = " ";
int roll = 0;
int won = 0;
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
System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

//
do 
{

roll1 = rng.Next(1, 7);
roll2 = rng.Next(1, 7);

//
if (roll1 == 1 && roll2 == 1)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. Snake eyes.");
        roll = roll + 1;
    }

//
else if (roll1 + roll2 == 7)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. A winner.");
        roll = roll + 1;
        won = won + 1;
    }

//
else if (roll1 + roll2 == 11)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. A winner.");
        roll = roll + 1;
        won = won + 1;
    }

//
else if (roll1 == roll2)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. Doubles!");
        roll = roll + 1;
    }

//
else
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}.");
        roll = roll + 1;
    }
System.Console.Write("Roll again? (y/n): ");
rollAgain = Console.ReadLine();
}

//
while (rollAgain == "y" && rollAgain != "n");
System.Console.WriteLine($"You rolled {roll} and won {won}");
}



//
if (choice == 3 || choice == 4)
{
// Exercise 3
System.Console.WriteLine("3");
}
//} while (choice !=5);

//Console.WriteLine("Goodbye.");

