Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 2;
if (b == 0)
{
    Console.WriteLine($"Число четное, ");
    Console.Write(a);
}
else
{
    Console.WriteLine($"Число не является четным, ");
}
    