Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000 || number > -100000 && number < -9999)
{
  int firstLeft = (number - number % 10000) / 10000;
  int firstRight = number % 10;
  int secondLeft = (number % 10000 - number % 1000) / 1000;
  int secondRight = (number % 100 - number % 10) / 10;
  if (firstLeft == firstRight && secondLeft == secondRight)
  {
    Console.WriteLine("Число является палиндромом!");
  }
  else
  {
    Console.WriteLine("Число НЕ является палиндромом!");
  }

}
else
{
  Console.WriteLine("Число НЕ является пятизначным!");
}
//Console.WriteLine(firstLeft + "1" + firstRight);