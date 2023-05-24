//Task1_______________________________
Console.WriteLine("Type 3 digits integer number");
int number = Convert.ToInt32(Console.ReadLine());
number = number / 10;
number = number % 10;
Console.WriteLine($"Middle digit is {number}");
//____________________________________
