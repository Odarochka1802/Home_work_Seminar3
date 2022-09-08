/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
 5 -> 1, 8, 27, 64, 125
 */
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int[] num){
  int counter = 0;
  int length = num.Length;
  while (counter <  length){
    num[counter] = Convert.ToInt32(Math.Pow(counter+1, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
//Создаем массив 
int[] array = new int[num];
//Заполняем массив
Cube(array);
//Вызываем массив по индексам 
PrintArry(array);
