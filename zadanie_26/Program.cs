// Возведите число А в натуральную степень B используя цикл.

Console.Clear();

Console.Write("Ввести число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Ввести число B: ");
int B = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine("Число А в степени В = " + result);