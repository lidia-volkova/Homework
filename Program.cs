// Решить задачи, используя МЕТОДЫ
// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16

// int Degree (int A, int B) 
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result = result * A;
//     }
//     return result;
// }  

// Console.WriteLine("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите степень, в которую нужно возвести Ваше число: ");
// int B = Convert.ToInt32(Console.ReadLine()); 

// int result = Degree(A, B);

// Console.WriteLine($"Число {A} в степени {B} будет равнятся {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumOfDigits (int num)
// {
//     int result = 0;
//     while (num>0)
//     {
//         result = result + num%10;
//         num = num / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// int result = SumOfDigits(num);
// Console.WriteLine($"Сумма цифр этого числа : {result}");

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandArray (int n)
// {
//     int [] arr = new int [n];
//     for (int i = 0; i < n; i++)
//     {
//         arr[i] = new Random().Next(1,100);
//     }
//     return arr;
// }

// void PrintArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine()); 

// PrintArray(CreateRandArray(num));
