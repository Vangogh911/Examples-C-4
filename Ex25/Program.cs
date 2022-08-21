// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void PowCycle (int num, int pow)
{
    int count = 1;
    int i = num;
    while (count < pow)
    {
        count++;
        i = i * num;
    }
    Console.WriteLine($"{num}, {pow} -> {i}");
}

PowCycle(3, 5);
PowCycle(2, 4);
