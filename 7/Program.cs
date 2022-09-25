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


            // Console.Clear();
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
            
 
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// Console.WriteLine("Cреднее арифметическое каждого столбца:");
// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double average = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         average = (average + numbers[i, j]);
//     }
//     average = average / n;
//     Console.Write(average + "; ");
    
// }
// Console.WriteLine();

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//             for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,3}", array[i, j]);
//         }
//             Console.WriteLine();
//     }
// }





// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
// 5 7 9 10


Console.Clear();
int[,] Input()
        
        {
            Console.Write("Введите размерность массива (N x M): \nN = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("M = ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            
            int[,] array = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rnd.Next(0, 20);
            return array;
        }
        
        
        void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,5}", array[i, j]);
        }
        void Reverse(int[,] array)
        {
            int Temp;
            for (int k = 0; k < array.GetLength(0); k++)
                for (int i = 0; i < array.GetLength(1) - 1; i++)
                    for (int j = i + 1; j < array.GetLength(1); j++)
                        if (array[k, j] < array[k, i])
                        {
                            Temp = array[k, j];
                            array[k, j] = array[k, i];
                            array[k, i] = Temp;
                        }
 
            for (int k = 0; k < array.GetLength(1); k++)
                for (int j = 0; j < array.GetLength(0) - 1; j++)
                    for (int i = j + 1; i < array.GetLength(0); i++)
                        if (array[i, k] < array[j, k])
                        {
                            Temp = array[i, k];
                            array[i, k] = array[j, k];
                            array[j, k] = Temp;
                        }
        }
 
     
            int[,] arr = Input();
            Console.WriteLine("Исходный массив:");
            printArray(arr);
            Reverse(arr);
            Console.WriteLine("Отсортированный массив:");
            printArray(arr);
            // Console.ReadKey();
        

