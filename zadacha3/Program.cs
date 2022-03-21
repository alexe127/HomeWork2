// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else if (number <= 5)
    Console.WriteLine("Рабочий день");
else
    Console.WriteLine("дня недели с таким номером не существует");
