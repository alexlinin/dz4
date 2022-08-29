// Задача 29:
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Укажите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numberArray = new int[number];

for (int i = 0; i < number; i++)
{
    numberArray[i] = new Random().Next(0,9);
}

Console.WriteLine($"Результат генерации массива: [ {String.Join(", ", numberArray) } ]");