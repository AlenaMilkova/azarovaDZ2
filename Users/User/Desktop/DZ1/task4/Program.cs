Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;
while (a > b)
{
    Console.Write($"{b}, ");
    b = b + 2;
}

    