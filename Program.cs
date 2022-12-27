/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1*/

/*Console.WriteLine("Введите трехзначное число: ");
int numbers = int.Parse(Console.ReadLine()!);
while ((numbers<100) || (numbers >999)){
    Console.WriteLine("Число не является трехзначным");
    return;

}
int number1 = numbers/10;
int number2 = number1%10;
Console.WriteLine($"{numbers} -> {number2}");*/

/*Console.WriteLine("Строково:");
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
string Num = Convert.ToString(number);
if (Num.Length == 3)
{
    Console.WriteLine($"Вторая цифра в числе {number} -> {Num[1]}");
}
else{
    Console.WriteLine($"Введено не верное число");
}*/


/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
while (number >100000){
    Console.WriteLine("Число не подходит");
    return;

}
if (number < 100){
    Console.WriteLine($"{number} -> третьей цифры нет");
    }
if ((number > 99) && (number < 1000)){
    Console.WriteLine($"{number} -> {number%10}");
    }
if ((number > 999) && (number < 10000)){
        int num_1 = (number/10)%10;
        Console.WriteLine($"{number} -> {num_1}");
    
}
if ((number > 9999) && (number < 100000)){
    int num_2 = (number/100)%10;
    Console.WriteLine($"{number} -> {num_2}");
    }*/

    /*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if ((num < 1) && (num > 7)){
     Console.WriteLine($"{num} -> не подходит");
}
if ((num > 0) && (num < 6)){
    Console.WriteLine($"{num} -> нет");
    }
if ((num > 5) && (num < 8)){
    Console.WriteLine($"{num} -> да");
    }

