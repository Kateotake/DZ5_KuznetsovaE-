// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillPrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(-100,100); 
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];

FillPrintArray(array);
Console.WriteLine();

int sum = 0;

for (int i = 0; i < array.Length; i++ ) 
{
    if (i % 2 == 1) 
    sum = sum + array[i];
}
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях, равна {sum}");
