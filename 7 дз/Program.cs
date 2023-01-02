//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2  
//1 -3,3 8 -9,9 
//8 7,8 -7,1 9
//Console.WriteLine("Введите значение m !");
//int m = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите значение n !");
//int n = int.Parse(Console.ReadLine()!);
//double[,] array = new double[m, n];

//void GetArray(double[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().NextDouble() * 10 * GenerationMinus();
//            array[i, j] = Math.Round(array[i, j], 1);
//        }
//    }
//}

//int GenerationMinus()
//{
//    Random random = new Random();
//    if (random.Next(10) > 5) return 1;
//    return -1;
//}

//void FullArray(double[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            Console.Write($"{matr[i, j]}  ");
//        }
//        Console.WriteLine();
//    }
//}
//GetArray(array);
//Console.WriteLine();
//FullArray(array);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Console.WriteLine("Введите значение элемента массива!");
//int elements = int.Parse(Console.ReadLine());
//int [,] array = new int[5, 5]; 
//if (elements >= 10)
//    Console.WriteLine($"{elements} - такого числа в массиве нет");

//void GetArray(int[,] array )
//{
//    for(int i = 0; i < array.GetLength(0);i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(1, 10);
//        }
//    }    
//}

//void FullArray(int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            Console.WriteLine($"{matr[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}
//void GetArrayElements(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            if (elements == array[i, j])
//                Console.Write($"{elements} ");
//        }
//    }
//}
//GetArray(array);
//FullArray(array);
//Console.WriteLine();
//GetArrayElements(array);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,

Console.WriteLine("Введите размер матрицы");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array  = new int [n, m];
Random random = new Random();
int[] summ = new int[n];
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		array[i, j] = random.Next(0, 10);
	}
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		Console.WriteLine($"{array[i,j]} ");
		summ[i] += array[j, i];
	}
	Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{
	Console.WriteLine($"{elem / m} ");
}