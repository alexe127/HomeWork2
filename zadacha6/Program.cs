// Найти расстояние между точками в пространстве 2D
Random rand = new Random ();
int a_x = rand.Next(1,10);
int a_y = rand.Next(1,10);
int b_x = rand.Next(1,10);
int b_y = rand.Next(1,10);

Console.WriteLine("координаты точки А -" + a_x + ":" + a_y);
Console.WriteLine("координаты точки B -" + b_x + ":" + b_y);

double rasst = Math.Sqrt( (a_x-b_x)*(a_x-b_x)+(a_y-b_y)*(a_y-b_y));
Console.WriteLine("расстояние между точками =" + rasst);