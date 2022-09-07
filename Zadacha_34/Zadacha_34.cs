// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillPrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(100,1000); 
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];

FillPrintArray(array);
Console.WriteLine();

int count = 0;

foreach (int item in array ) 
{
    if (item % 2 == 0) count++;
}
Console.WriteLine ($"Количество четных элементов равно {count}");