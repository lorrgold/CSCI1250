
/*
* Name: Angel Goldsmith
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 14, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/

//constants
const double taxRate =.18;
const int slice = 8;

//drive variables
double tripMiles;
double milesGallon;
double priceGallon;


//pizza variables
int pizzaAmount;
double pizzaPrice;
double pizzaCost;

//trip money
double tripTotal;



//getting variable inputs
Console.Write("Round trip miles: ");
tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
milesGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
priceGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
pizzaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
pizzaPrice = Convert.ToDouble(Console.ReadLine());


Console.WriteLine(" ");



//Part 1
Console.WriteLine("=== Part 1: The Trip ===");

Console.WriteLine("Fuel cost: " + FuelCost(tripMiles, milesGallon, priceGallon).ToString("C"));

pizzaCost = pizzaAmount*pizzaPrice;
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

tripTotal = FuelCost(tripMiles, milesGallon, priceGallon)+pizzaCost;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));



//Line Break
Console.WriteLine(" ");


//Part 2
Console.WriteLine("=== Part 2: The Group ===");

//arrays
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

//variables from array
double peopleGoing = names.Length;
double slicesEach = (pizzaAmount*slice)/names.Length;
double costPerPerson = tripTotal/names.Length;

Console.WriteLine("People going: " + peopleGoing);
Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

//Line Break
Console.WriteLine(" ");



//Part 3
Console.WriteLine("=== Part 3: Who Works How Long ===");

//variables for loop
double totalHours = 0;
double totalPay = 0;
double longest = 0;

for (int i = 0; i < names.Length; i++)
{
    totalHours = totalHours + hoursWorked[i];
    double homePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePerHour = homePay/hoursWorked[i];
    double hoursMustWork = HoursToCover(costPerPerson, takeHomePerHour);
    totalPay = totalPay + homePay;
    longest = Math.Max(longest, hoursMustWork);
    Console.WriteLine($"{names[i]}: takes home {homePay.ToString("C")} for {hoursWorked[i]} hours, {takeHomePerHour.ToString("C")} per hour, must work {hoursMustWork.ToString("F2")} hours");

}

//Line Break
Console.WriteLine(" ");

//Totals and Longest
Console.WriteLine("Total hours worked: " + totalHours);
Console.WriteLine("Total take home pay: " + totalPay.ToString("C"));
Console.WriteLine("Longest anyone must work: " + longest.ToString("F2"));


//Methods

//Returns the FuelCost/ Cost of fuel for trip
static double FuelCost(double miles, double milesGallon, double priceGallon)
{
    double gallonsNeeded = miles/milesGallon;
    return gallonsNeeded*priceGallon;
}

//Returns TakeHomePay/ Amount of money they take home
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours*hourlyRate;
    double taxWithheld = grossPay*taxRate;
    return grossPay-taxWithheld;

}

//Returns HoursToCover/ Hours needed to work
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed/takeHomePerHour;
}