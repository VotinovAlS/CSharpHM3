Console.Write("Введите сумму вклада: ");
int deposit = Convert.ToInt32(Console.ReadLine());


if (deposit > 0 && deposit < 100)
{
  double profit = deposit * 1.05;
  Console.Write("Сумма вклада с начисленными процентами составляет: " + Math.Round(profit, 2));
}
else if (deposit >= 100 && deposit < 200)
{
  double profit = deposit * 1.07;
  Console.Write("Сумма вклада с начисленными процентами составляет: " + Math.Round(profit, 2));
}
else if (deposit >= 200)
{
  double profit = deposit * 1.1;
  Console.Write("Сумма вклада с начисленными процентами составляет: " + Math.Round(profit, 2));
}
else
{
  Console.Write("Сумма вклада НЕ может быть отрицательной, либо равна 0!");
}




// if (N >0)
// {
// for(int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }
// }
// else
// {
//   for(int i = -1; i >= N; i--)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }
// }