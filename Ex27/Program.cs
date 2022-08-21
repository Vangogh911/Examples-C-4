// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

void DigitSum (int num)
{
    int savedNum = num;
    int sum = 0;
    while(num > 10)
    {
        sum = sum + num%10;
        num = num/10;
    }
    sum = sum + num%10;
    Console.WriteLine($"{savedNum} -> {sum}");
}

DigitSum(452);
DigitSum(82);
DigitSum(9012);
