// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Promt(string msg)
{
  System.Console.Write(msg + "-> ");
  return int.Parse(Console.ReadLine());
}

bool CheckBinary(int number)//Первый вариант решения
{
  if (number == 1)
  {
    return true;
  }
  if (number % 2 != 0)
  {
    return false;
  }
  return CheckBinary(number / 2);
}

bool CheckBinary2(int number)//Второй вариант решения
{
  if (number == 1)
  {
    return true;
  }
  return (number % 2 == 0) && CheckBinary2(number / 2);
}


int number = Promt("Введите число ");//Первый вариант решения
bool result = CheckBinary(number);
System.Console.WriteLine(result);

result = CheckBinary2(number);//Второй вариант решения
System.Console.WriteLine(result);