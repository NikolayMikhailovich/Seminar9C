// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Promt(string msg)
{
  System.Console.Write(msg + "-> ");
  return int.Parse(Console.ReadLine());
}

int PowNumber(int a, int n)
{
  if (n == 0)
  {
    return 1;
  }
  return a * PowNumber(a, n - 1);
}

int number1 = Promt("Введите основание ");
int number2 = Promt("Введите степень ");
int result = PowNumber(number1, number2);
System.Console.WriteLine(result);