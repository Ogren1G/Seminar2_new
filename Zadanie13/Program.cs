Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int x = n;
if (n <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(n > 999)
    {
        n = n / 10;
    }
 int result = n % 10;
    
Console.WriteLine($"{result} является третьей цифрой числа {x}");
}
