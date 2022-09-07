// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillPrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(-100,100); 
        Console.Write($"{arr[i]} ");
    }
}
void MinMax(int[] arr3) 
{
    int i = 0;
    int j = 0;
    int maxPos = 0;
    int minPos = 0; 
    while ( i < arr3.Length)  
    {
        if (arr3[i] < arr3[minPos]) minPos = i;
        i++;
    }
      Console.WriteLine($"Минимальное значение массива : {arr3[minPos]}");
        
    while (j < arr3.Length)
    {
        if (arr3[j] > arr3[maxPos]) maxPos = j;
        j++;
    }
     Console.WriteLine($"Максимальное значение массива : {arr3[maxPos]}");
     Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {arr3[maxPos] - arr3[minPos]}");
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];

FillPrintArray(array);
Console.WriteLine();
MinMax(array);
