// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// int power = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(number, power);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());


// static int Foo(int value) {
//     if (value < 10)
//     return value;

//     int lastDigit = value % 10; 
//     int nextDigit = value / 10;

// return lastDigit + Foo(nextDigit);
// } 

// Console.WriteLine(Foo(number));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Programm {
    static void Main(string[]args) {
        Console.Write("What will be array size? ");
        int arraySize = Convert.ToInt32(Console.ReadLine());
        int [] array = new int [arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\n Введите значение для элемента массива {i}:\t");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++) {
            Console.Write(array[i] + " ");
        }
    }
}