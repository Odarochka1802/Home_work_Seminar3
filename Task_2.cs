Console.WriteLine("Введите координаты точек в последовательности X, Y, Z: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

//Создаем функцию 
double Decision(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

//Присваиваем значению Distance вызов функции с задаными координатами 
double Distance = Decision(x1, x2, y1, y2, z1, z2);

Console.WriteLine($"Расстояние между точками в 3D пространстве: {string.Format("{0:N2}", Distance)}");//отбрасываем символы после зяпятой 