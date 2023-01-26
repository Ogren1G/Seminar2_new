Console.WriteLine("Введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());

int a = 0; int b = 0; int c = 0;

if (x > 999)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
a = x / 100;
b = x % 100;
c = b / 10;

Console.WriteLine(c);
}
