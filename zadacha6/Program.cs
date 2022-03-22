
// Найти расстояние между точками в пространстве 2D
Random rand = new Random ();
int a_x = rand.Next(1,10);
int a_y = rand.Next(1,10);
int b_x = rand.Next(1,10);
int b_y = rand.Next(1,10);

Console.WriteLine("координаты точки А -" + a_x + ":" + a_y);
Console.WriteLine("координаты точки B -" + b_x + ":" + b_y);

double rasst = Math.Sqrt( (a_x-b_x)*(a_x-b_x)+(a_y-b_y)*(a_y-b_y));
Console.WriteLine("расстояние между точками 2D =" + rasst);

// 6 Найти расстояние между точками в пространстве 3D
Random rand3d = new Random ();
int ax = rand3d.Next(1,10);
int ay = rand3d.Next(1,10);
int az = rand3d.Next(1,10);
int bx = rand3d.Next(1,10);
int by = rand3d.Next(1,10);
int bz = rand3d.Next(1,10);

Console.WriteLine("координаты точки А -" + ax + ":" + ay + ":" + az);
Console.WriteLine("координаты точки B -" + bx + ":" + by + ":" + bz);

double rasst2= Math.Sqrt( (ax-bx)*(ax-bx)+(ay-by)*(ay-by)+(az-bz)*(az-bz));
Console.WriteLine("расстояние между точками 3D =" + rasst2);
