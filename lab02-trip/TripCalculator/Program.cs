/*
 *Name: Angel Goldsmith
 *Course: CSCI 1250, Section 001
 *Assignment: Lab 02, Trip Calculator
 *Date: September 23, 2026
 *Description: Calculates the fuel, food, and work hours behind one trip
 */

 //Calculates costs for the road trip
Console.WriteLine("---Part 1: Road Trip---");

double tripMiles;
double milesGallon;
double priceGallon;
double gallonsNeeded;
double fuelCost;

Console.Write("Round trip miles: ");
tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
milesGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
priceGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" "); 

gallonsNeeded = tripMiles/milesGallon;
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));

fuelCost = gallonsNeeded*priceGallon;
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));


Console.WriteLine(" ");

//Calculates the cost for the pizza party
Console.WriteLine("---Part 2: Pizza Party---");

int peopleAmount;
int pizzaAmount;
double pizzaPrice;
const int slice = 8;
int totalSlices;
double slicePerPerson;
double pizzaCost;

Console.Write("How many people are going: ");
peopleAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas: ");
pizzaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
pizzaPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" "); 

totalSlices = pizzaAmount*slice;
Console.WriteLine("Total slices: " + totalSlices);

slicePerPerson = (double)totalSlices/peopleAmount;
Console.WriteLine("Slices per person: " + slicePerPerson.ToString("F1"));

pizzaCost = pizzaAmount*pizzaPrice;
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));


Console.WriteLine(" ");

//Calculates your paycheck
Console.WriteLine("---Part 3: Paycheck---");

double weekHours;
double hourlyRate;
const double taxRate =.18;
double grossPay;
double taxWithheld;
double takeHomePay;


Console.Write("Hours worked this week: ");
weekHours = Convert.ToDouble(Console.ReadLine());

Console.Write("Hourly rate: ");
hourlyRate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");

grossPay = weekHours*hourlyRate;
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));

taxWithheld = grossPay*taxRate;
Console.WriteLine("Tax witheld: " + taxWithheld.ToString("C"));

takeHomePay = grossPay-taxWithheld;
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));


Console.WriteLine(" ");

//Calculates the cost of the whole trip
Console.WriteLine("---Part 4: The Whole Trip---");
double tripTotal;
double costPerPerson;
double takeHomePayPerHour;
double hoursMustWork;

tripTotal = fuelCost+pizzaCost;
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

costPerPerson = tripTotal/peopleAmount;
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

takeHomePayPerHour = takeHomePay/weekHours;
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));

hoursMustWork = costPerPerson/takeHomePayPerHour;
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("F2"));