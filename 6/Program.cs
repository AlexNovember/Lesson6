// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Console.Clear();
// Console.Write("Введите элементы(через запятую): ");
// int[] elements = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse); //помогает получить отдельные целые числа в строке, разделенные знаком, укзанным в скобках.
// int count = 0;
 
// for (int i = 0; i < elements.Length; i++)
// {
//     if (elements[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля: {count}");

Console.Clear();
Console.Write("Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] MassiveOfNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    MassiveOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] MassiveOfNumbers)
{
  int count = 0;
  for (int i = 0; i < MassiveOfNumbers.Length; i++)
  {
    if(MassiveOfNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
void PrintArray(int[] numbers)
{
        for(int i = 0; i < MassiveOfNumbers.Length; i++)
    {
        if (i!=(MassiveOfNumbers.Length-1))
              Console.Write($"{numbers[i]}, ");
        else 
              Console.Write($"{numbers[i]}");
    }
        Console.WriteLine();
}


InputNumbers(m);
Console.Write("Наш массив: ");
PrintArray(MassiveOfNumbers);
Console.WriteLine($"Чисел больше нуля: {Comparison(MassiveOfNumbers)} ");
