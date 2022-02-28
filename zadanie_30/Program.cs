// Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.Clear();

Console.Write("Ввести число: ");
int num = int.Parse(Console.ReadLine());
int x = 2;
while (x <= num)
{
    if (x % 2 == 0)
    {
        Console.WriteLine("Куб чисела заканчивающийся на чётную цифру: " + x * x * x);
        {
            x = x + 2;
        }
    }
}
