string firstName;
string lastName;
int age;
string stringAge;

//Stores users first name, last name, and their age
Console.WriteLine("What is your first name: ");
firstName = Console.ReadLine();


Console.WriteLine("What is your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("How old are you: ");
stringAge = Console.ReadLine();
age = Convert.ToInt32(stringAge);

var lastInitial = lastName[0];

var firstInitial = firstName[0];

Console.WriteLine($"Hello, {firstName} {lastName}! Your Initials are {firstInitial}.{lastInitial}., and you are {age} years old");