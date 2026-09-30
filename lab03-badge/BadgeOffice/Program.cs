/*
* Name: Angel Goldsmith
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
//Part 1: The Name

//random
Random rng = new Random();

//full name
Console.Write("Full name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePostion = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePostion);
string lastName = fullName.Substring(spacePostion + 1);

//initials
string initials = firstName.ToUpper()[0] + "." + lastName.ToUpper()[0] + ".";
char firstInitial = firstName[0];
char lastInitial = lastName[0];
//username
string username = firstInitial + lastName;

//last name length
int lastNameLetters = lastName.Length;

//write everything out
Console.WriteLine("Name on badge: " + fullName.ToUpper());
Console.WriteLine("Username: " + username.ToLower());
Console.WriteLine("Initials: " + initials.ToUpper());
Console.WriteLine("Letters in last name: " + lastNameLetters);

Console.WriteLine(" ");

//Part 2: The Numbers

//rng
int studentID = rng.Next(100000,1000000);
int lockerNumber = rng.Next(1,501);

//output
Console.WriteLine("Student ID: " + studentID);
Console.WriteLine("Locker: " + lockerNumber);

Console.WriteLine(" ");

//Part 3: The Walk

//dorm coords
Console.Write("Dorm X: ");
int dormX = Convert.ToInt32(Console.ReadLine());
Console.Write("Dorm Y: ");
int dormY = Convert.ToInt32(Console.ReadLine());

//classroom coords
Console.Write("Classroom X: ");
int classroomX = Convert.ToInt32(Console.ReadLine());
Console.Write("Classroom Y: ");
int classroomY = Convert.ToInt32(Console.ReadLine());

//student speed
Console.Write("Walking speed in feet per second: ");
double studentSpeed = Convert.ToDouble(Console.ReadLine());

//distance
double distance;

//x
double x = (double)classroomX - dormX;
x = Math.Pow(x, 2);

//y
double y = (double)classroomY - dormY;
y = Math.Pow(y, 2);

distance = x + y;
distance = Math.Sqrt(distance);

double time = Math.Round(distance/studentSpeed, 0);
double minutes = Math.Floor(time/60);
double seconds = Math.Round(time%60);

Console.WriteLine(" ");

Console.WriteLine("Distance: " + distance.ToString("F1") + "feet");
Console.WriteLine($"Walk time: {minutes} minutes {seconds} seconds ");

Console.WriteLine(" ");

//Part 4: The Badge

int checkDigit = studentID/9;

Console.WriteLine("==================================");
Console.WriteLine("\tETSU STUDENT BADGE");
Console.WriteLine("==================================");
Console.WriteLine("NAME".PadRight(10) + fullName.ToUpper());
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine("ID".PadRight(10) + studentID +"-"+ checkDigit);
Console.WriteLine("LOCKER".PadRight(10) + lockerNumber
);
Console.WriteLine("WALK".PadRight(10) + minutes + " min " + seconds + " sec" );
Console.WriteLine("==================================");