// Принимает на вход число и выдает сумму цифр в этом числе.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 0;
while (a != 0)
{
    int LastDig = a%10;
    count = count + LastDig;
    a = a/10;
}
Console.WriteLine("Сумма цифр в этом числе равна " + count);
