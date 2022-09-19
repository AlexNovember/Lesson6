// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Console.Clear();
// Console.Write("Введите элементы(через запятую): ");
// double[] elements = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse); //помогает получить отдельные целые числа в строке, разделенные знаком, укзанным в скобках.
// double count = 0;
 
// for (double i = 0; i < elements.Length; i++)
// {
//     if (elements[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля: {count}");

// Console.Clear();
// Console.Write("Введи количество чисел: "); // Ввод количества цифр в массиве
// double m = Convert.ToInt32(Console.ReadLine());
// double[] MassiveOfNumbers = new double[m];

// void InputNumbers(double m)   // Ввод цифр в массив
// {
// for (double i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");   
//     MassiveOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }

// double CompareNumbers(double[] MassiveOfNumbers)  // Сравниваем цифры с 0
// {
//   double count = 0;
//   for (double i = 0; i < MassiveOfNumbers.Length; i++)
//   {
//     if(MassiveOfNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }
// void PrintArray(double[] numbers)  // Готовим вывод массива, убираем последнюю запятую
// {
//         for(double i = 0; i < MassiveOfNumbers.Length; i++)
//     {
//         if (i!=(MassiveOfNumbers.Length-1))
//               Console.Write($"{numbers[i]}, ");
//         else 
//               Console.Write($"{numbers[i]}");
//     }
//         Console.WriteLine();
// }

// //Выводим мнформацию
// InputNumbers(m);
// Console.Write("Наш массив: ");
// PrintArray(MassiveOfNumbers);
// Console.WriteLine($"Чисел больше нуля => {CompareNumbers(MassiveOfNumbers)} ");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[,] Point = new double[2, 2];  //задаем формат точек (x, y до 2-x)
double[] IntersectionPoint = new double[2]; //точка пересечения

void InputCoefficients() // ввод значений - точки каждой прямой
{
  for (int i = 0; i < Point.GetLength(0); i++)
  {
    Console.Write($"Введите точки {i+1}-ой прямой:\n");
    for (int j = 0; j < Point.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите точку b{i+1}: ");
      else Console.Write($"Введите точку k{i+1}: ");
      Point[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] Point) // считаем
  // x = (b2 - b1)/(k1 - k2);
  // y = k1 * x + b1;
  // b1 = 0,0 b2 = 1,0 k1 = 0,1 k2 = 1,1
  {
  IntersectionPoint[0] = (Point[1,0] - Point[0,0]) / (Point[0,1] - Point[1,1]);
  IntersectionPoint[1] = Point[0,1] * IntersectionPoint[0] + Point[0,0];
  return IntersectionPoint;
}

void Output(double[,] Point) // совпадения
// k1 = k2 & b1 = b2 Прямые совпадают
// k1 = k2 Прямые параллельны
// иначе вывод точки пересечения
{
  if (Point[0,1] == Point[1,1] && Point[0,0] == Point[1,0]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (Point[0,1] == Point[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Decision(Point);
    Console.Write($"Точка пересечения прямых: ({IntersectionPoint[0]}, {IntersectionPoint[1]})");
  }
}

InputCoefficients();
Output(Point);


// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1)/(k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
