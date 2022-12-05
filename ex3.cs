Console.WriteLine("enter week day number:");
int number = int.Parse(Console.ReadLine() ??"");
Console.WriteLine(number);
if (number >0 && number<8)
    if (number >5)
    Console.WriteLine("yes it is weekend!");
    else
    Console.WriteLine("no");
else
Console.WriteLine("you enter wrong number");