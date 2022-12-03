// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Function(int a) {
// int step = a;
// for (int i = 1; i < b; i++)
// {
//   step = step * a;
// }
// return step;
// }

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int X = Function(a);
// Console.WriteLine($"A в степени B равно: {X} ");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// int Function(int i) {
// int sum = 0;
// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// return sum;
// }

// Console.WriteLine("Введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int X = Function(i);
// Console.WriteLine($"сумма всех цифр в числе равна: {X}");





//Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
//  int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }