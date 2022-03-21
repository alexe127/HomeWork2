// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("введите координаты x, x!=0:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("введите координаты y, y!=0:");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
  Console.WriteLine("первая четверть");
}
else if (x < 0 && y > 0)
{
  Console.WriteLine("вторая четверть");
}
else if (x < 0 && y < 0)
{
  Console.WriteLine("третья четверть");
}
else if (x > 0 && y < 0)
{
  Console.WriteLine("четвёртая четверть");
}