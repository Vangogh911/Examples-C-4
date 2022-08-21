// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void Array8Digit()
{
    int[] array = new int[8];
    int count = 0;
    Random rnd = new Random();
    while (count<8)
    {
        array[count] = rnd.Next(1, 100);
        count++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

Array8Digit();
