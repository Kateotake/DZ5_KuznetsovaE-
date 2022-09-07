// Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. 
//N - задается пользователем.


void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double DlinaOtrezka (int N)
{
    int [] array_x = new int[N];
    int [] array_y = new int[N];
    Console.WriteLine ("Введите координаты точки Х:");
    for (int i = 0; i < N; i++)
    {
        array_x[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine ("Введите координаты точки Y:");
    for (int j = 0; j < N; j++)
    {
        array_y[j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Координаты точки Х : ");
    PrintArray(array_x);
    Console.Write("Координаты точки Y : ");
    PrintArray(array_y);

    double sum = 0;
    for (int i = 0; i < N; i++)
    {
        sum += (array_x[i] - array_y[i]) * (array_x[i] - array_y[i]);
    }

    double result = Math.Sqrt(sum);
    return result;
}
double res = DlinaOtrezka(4); //размерность пространства вводим здесь
Console.WriteLine ($"Расстояние между точками X и Y равно {res} ");