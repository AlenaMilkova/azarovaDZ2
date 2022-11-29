Console.Clear();
Console.WriteLine("Введите число1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число3: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;
{
    if (c > max) max = c;
    {
        Console.WriteLine($"Максимальное число, ");
    Console.Write(max);
    }

}

