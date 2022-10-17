int n ;
string result = "";

Console.WriteLine("Введите число");
n = int.Parse(Console.ReadLine()!);

if (n > 1)
{
    for (int i = 2; i <= n; i += 2)

        if (i == 2) result = i.ToString();
        else result = result + "; " + i;
}
Console.WriteLine("Диапазон четных чисел " + result);
