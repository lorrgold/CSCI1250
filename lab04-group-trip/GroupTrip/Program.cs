
//constants
const double taxRate =.18;
const int slice = 8;

//drive variables
double tripMiles;
double milesGallon;
double priceGallon;
double gallonsNeeded;
double fuelCost;

//pizza variables
int pizzaAmount;
double pizzaPrice;
int totalSlices;
double slicePerPerson;
double pizzaCost;

//pay variables
double grossPay;
double taxWithheld;
double takeHomePay;

//trip money
double tripTotal;
double costPerPerson;
double takeHomePayPerHour;
double hoursMustWork;

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


Console.WriteLine(" ");


Console.WriteLine("=== Part 2: The Group ===");


Console.WriteLine("=== Part 3: Who Works How Long ===");















static double FuelCost(double tripMiles, double milesGallon, double priceGallon)
{
    double gallonsNeeded = tripMiles/milesGallon;
    return gallonsNeeded*priceGallon;
}


static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours*hourlyRate;
    double taxWithheld = grossPay*taxRate;
    return grossPay-taxWithheld;

}


// static double HoursToCover(double amountOwed, double takeHomePayPerHour)
// {
//     double costPerPerson = tripTotal/peopleAmount;
//     takeHomePayPerHour = takeHomePay/weekHours;
//     return costPerPerson/takeHomePayPerHour;
// }