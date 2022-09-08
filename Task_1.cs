/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.Write("Введите число: ");
// принимаем число как строку
string number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

// проверяем на соответствие пятизначному числу 
if (number.Length == 5)
{
    CheckNumber(number);//вызываем функцию 
}
else Console.WriteLine($"Введи правильное число");
