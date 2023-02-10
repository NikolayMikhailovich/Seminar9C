// // Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Promt(string msg)
{
  System.Console.Write(msg + "-> ");
  return int.Parse(Console.ReadLine());
}

bool CheskPrimary(int number, int divider)
{
  if (divider == 1)
    return true;
  if (number % divider == 0)
    return false;
  return CheskPrimary(number, divider - 1);
}

int number = Promt("Введите число ");
bool result = CheskPrimary(number, number - 1);
System.Console.WriteLine(result);