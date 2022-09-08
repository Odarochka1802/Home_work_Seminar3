
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