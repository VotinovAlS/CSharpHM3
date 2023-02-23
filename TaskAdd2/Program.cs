Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 9;
int i = 1;
int number1 = number;
while (number1 / 10 > 0)
{
  i++;
  number1 = number1 / 10;
}

if (i % 2 == 1)
{
  number1 = number;
  for (int n = 0; n < i; n++)
  {
    if (number1 % 10 > max)
    {
      max = number1 % 10;
    }
    number1 = number1 / 10;
  }
  number1 = number;
  for (int n = 0; n < i; n++)
  {
    if (number1 % 10 < min)
    {
      min = number1 % 10;
    }
    number1 = number1 / 10;
  }
  // Console.WriteLine(i);
  // Console.WriteLine(max);
  // Console.WriteLine(min);

  double average = (number % Math.Pow(10, i / 2 + 1) - number % Math.Pow(10, i / 2)) / Math.Pow(10, i / 2);
  if (average == (max - min))
  {
    Console.WriteLine("Число интересное!");
  }
  else
  {
    Console.WriteLine("Число НЕ интересное!");
  }
  //Console.WriteLine(average);
}

else Console.WriteLine("Число четное, невозможно выполнить задание!");
