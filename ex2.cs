Console.WriteLine("enter number:");
string  str = Console.ReadLine() ??"";
int number = Convert.ToInt32(str);
Console.WriteLine($"number :{number}");
if (number >99)
Console.WriteLine($"third digit is: {str[2]}");
else
Console.WriteLine("there isn't third digit");