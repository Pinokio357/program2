Console.WriteLine("enter number:");
string  numberstr = Console.ReadLine();
int number = Convert.ToInt32(numberstr);
Console.WriteLine($"number ={number}");
int digitone =number%10;
int digittwo =((number-digitone)/10)%10;
Console.WriteLine($"second digit ={digittwo}");