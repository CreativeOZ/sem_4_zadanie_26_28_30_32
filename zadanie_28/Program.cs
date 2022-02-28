// Подсчитайте сумму цифр в числе.
Console.Clear();

Console.Write("Ввести число: ");
string A = Console.ReadLine();
int num = int.Parse(A);
int sum = 0;
while (num != 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine("Сумма цифр в числе: " + sum);
