int choice = 0;
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
System.Console.WriteLine("1");
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