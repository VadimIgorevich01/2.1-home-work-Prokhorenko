//Task1_______________________________
Console.WriteLine("Type 3 digits integer number");
int numberTask1 = Convert.ToInt32(Console.ReadLine());
numberTask1 = numberTask1 / 10;
numberTask1 = numberTask1 % 10;
Console.WriteLine($"Middle digit is {numberTask1}");
//____________________________________

// Task2_________________________________
Console.WriteLine("Type an integer number");
int typedNumber = Convert.ToInt32(Console.ReadLine());

int HowManyDigits (int numb)
{
    int length = 1;
    while (numb > 9)
    {
        numb = numb / 10;
        length++;
    }
    return length;
}

// Console.WriteLine($"There are - {HowManyDigits(typedNumber)} digits"); увидеть количество цифр в номере

int length = HowManyDigits(typedNumber);
int maxIndex = length - 1;
int [] array = new int [length];
int digit;
while (maxIndex > 0)
{
    digit = typedNumber % 10;
    array [maxIndex] = digit;
    typedNumber = typedNumber / 10;
    maxIndex = maxIndex -1;
}
array [maxIndex] = typedNumber;

// int i = 0;                   увидеть полученный массив
// while (i < array.Length)
// {
//     Console.Write(array [i]);
//     i++;
// }

int desiredDigit = 3;
int requiredIndex = desiredDigit - 1;
if (requiredIndex > array.Length || requiredIndex == array.Length)
{
    Console.WriteLine($"Digit {desiredDigit} not found");
}
else
{
    Console.WriteLine($"Digit {desiredDigit} is - {array[requiredIndex]}");
}
//____________________________________

//Task3_______________________________
Console.WriteLine ("Type integer from 1 till 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}