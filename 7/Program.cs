// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
          
//         Console.Write("{0,6}", array[i, j] + " ");
//     }
//         Console.WriteLine();
//     }
// }
    
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int linesMassive = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columnsMassive = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesMassive, columnsMassive];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);




// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


     
            // Console.Write("Введите строку: ");
            // int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
            // Console.Write("Введите столбец: ");
            // int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
            // int n = 3; // размер массива
            // int m = 4; // размер массива
            // Random array = new Random();
            // int[,] arr = new int[n, m];
            // Console.WriteLine("Наш массив:");
            // for (int i = 0; i < arr.GetLength(0); i++)
            // {
            //     for (int j = 0; j < arr.GetLength(1); j++)
            //     {
            //         arr[i, j] = array.Next(0, 9);
            //         Console.Write("{0,2} ", arr[i, j]);
            //     }
            //     Console.WriteLine();
            // }
            // if (position1 < 0 | position1 > arr.GetLength(0) - 1 | position2 < 0 | position2 > arr.GetLength(1) - 1)
            // {
            //     Console.WriteLine("Такого числа в массиве нет");
            // }
            // else
            // {
            //     Console.WriteLine($"Значение элемента массива строки {position1} столбца {position2} = {0} ", arr[position1, position2]);
            // }
            
 

//  int[,] someArray = new int[10, 10];
//     int rows = someArray.GetUpperBound(0) + 1;
//     int columns = someArray.GetUpperBound(1) + 1;
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             someArray[i, j] = rand.Next(-100, 100);
//             Console.Write("{0,4}", someArray[i, j]);
//         }
//         Console.WriteLine();
//     }
//     for (int i = 0; i < columns; i++)
//     {
//         int tmp = someArray[1,  i];
//         someArray[1, i] = someArray[3, i];
//         someArray[3, i] = tmp;
 
//     }
//     for (int i = 0; i < rows; i++)
//     {
//         int tmp = someArray[i, 2];
//         someArray[i, 2] = someArray[i, columns - 1];
//         someArray[i, columns - 1] = tmp;
//     }
//     Console.WriteLine("Transformed array: ");
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write("{0,4}", someArray[i, j]);
//         }
//         Console.WriteLine();
//     }

