// Показать числа от -N до N
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = -num; i <= num; i++)
{
    Console.Write(i + " ");
}