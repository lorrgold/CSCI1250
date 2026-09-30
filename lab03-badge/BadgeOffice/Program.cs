//Part 1: The Name
//full name
Console.Write("What is your full name? ");
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


