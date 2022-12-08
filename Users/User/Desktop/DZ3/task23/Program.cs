//Задача 23
//Ввод данных
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Функция возведения в куб
void Cube(int number)
{
    number = number * number*number;
    Console.Write(number + ", "); //вывод результата
}
int N = EnterData("Введите число N: ");
int i = 1;
while (i <= N)
{
    Cube(i);
    i++;
} 









