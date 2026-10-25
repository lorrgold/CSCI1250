/*
* Name: Angel Goldsmith
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/
Random rng = new Random (4000);
//variables
int choice = 0;
int score = 0;
int roll1 = 0;
int roll2 = 0;
string rollAgain = " ";
int roll = 0;
int won = 0;
int scoreAmount = 0;
int total = 0;
double average = 0;
int highest = 0;
int passing = 0;

//Menu
//dowhile: it has to run before anything can be asked, just like how to menu has to be shown before a question is asked
do
{
//constants - the # of options and the exit option
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
Console.Write("Chose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

//while: might have to run multiple times if the conditions are met
while (choice > 5)
{
    System.Console.WriteLine("Choose a number from 1 to 5.");
    Console.Write("Chose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}


//GRADE CHECKER
if (choice == 1 || choice == 4)
{
// Exercise 1
System.Console.WriteLine(" ");
System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
Console.Write("Score: ");
score = Convert.ToInt32(Console.ReadLine());

//while: might have to run multiple times if the conditions are met
while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100");
        Console.Write("Score: ");
    score = Convert.ToInt32(Console.ReadLine());
    }

if (score >= 90)
    {
        System.Console.WriteLine($"{score} earns an A.");
    }

else if (score >= 80)
    {
        System.Console.WriteLine($"{score} earns a B.");
    }

else if (score >= 70)
    {
        System.Console.WriteLine($"{score} earns a C.");
    }

else if (score >= 60)
    {
        System.Console.WriteLine($"{score} earns a D.");
    }

else if (score <= 59)
    {
        System.Console.WriteLine($"{score} earns a F.");
    }
 System.Console.WriteLine(" ");
}


//DICE TABLE
if (choice == 2 || choice == 4)
{
// Exercise 2
System.Console.WriteLine(" ");
System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

//dowhile: it has to keep doing this until said otherwise
do 
{

roll1 = rng.Next(1, 7);
roll2 = rng.Next(1, 7);


if (roll1 == 1 && roll2 == 1)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. Snake eyes.");
        roll = roll + 1;
    }


else if (roll1 + roll2 == 7)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. A winner.");
        roll = roll + 1;
        won = won + 1;
    }


else if (roll1 + roll2 == 11)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. A winner.");
        roll = roll + 1;
        won = won + 1;
    }


else if (roll1 == roll2)
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}. Doubles!");
        roll = roll + 1;
    }


else
    {
        System.Console.WriteLine($"Roll: {roll1} and {roll2}, total {roll1 + roll2}.");
        roll = roll + 1;
    }
System.Console.Write("Roll again? (y/n): ");
rollAgain = Console.ReadLine();
}

//while: it has to do it while only these conditions are correct
while (rollAgain == "y" && rollAgain != "n");
System.Console.WriteLine($"You rolled {roll} and won {won}");
System.Console.WriteLine(" ");
}



//SCORE REPORT
if (choice == 3 || choice == 4)
{
//Exercise 3
System.Console.WriteLine(" ");
System.Console.WriteLine("=== Exercise 3: The Score Report ===");

//constant - # of scores
int[] scores = new int[5];
scoreAmount = scores.Length;

//for: it has to differentiate the different scores
for (int i = 0; i < scoreAmount; i++)
    {
        System.Console.Write($"Score {i + 1}: ");
        scores[i] = Convert.ToInt32(Console.ReadLine());
    }
    
//foreach: it has to do it for every score 
foreach (int percentage in scores)
    {
        total += percentage;
        average = (double)total / 5;

        //constant- passing grade
        if (percentage >= 60)
        {
            passing = passing + 1;
        }
    }

    highest = scores.Max();

    System.Console.WriteLine(" ");
    System.Console.WriteLine("Scores entered: " + scoreAmount);
    Console.WriteLine("Total: " + total);
    Console.WriteLine("Average: " + average.ToString("F1"));
    Console.WriteLine("Highest: " + highest);
    System.Console.WriteLine($"Passing: {passing} out of 5");
    System.Console.WriteLine(" ");
}


} while (choice !=5);

//EXIT
System.Console.WriteLine(" ");
Console.WriteLine("Goodbye.");

