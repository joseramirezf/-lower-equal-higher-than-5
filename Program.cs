Console.WriteLine("Lower, Equal or higher than 5");

Console.WriteLine("Enter a Number");

string input = Console.ReadLine() ?? "n";
int number = Int32.Parse(input);
if (number < 5)
{
     Console.WriteLine("The number is less than 5");
} else {
    if (number == 5)
{
     Console.WriteLine("The number is equal to 5");
} else {
    Console.WriteLine("The number is higher than 5");
}
}
