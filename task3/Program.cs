// Задача 3: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Promt(string msg)
{
  System.Console.Write(msg + "-> ");
  return int.Parse(Console.ReadLine());
}

int ShowNumbers(int num)
{
  if (num == 0)
  {
    return 0;
  }
  return num % 10 + ShowNumbers(num / 10);
}

int number = Promt("Введите число ");
int result = ShowNumbers(number);
System.Console.WriteLine(result);