//
//
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];

for (int a = 0; a < n; a ++)
{
    numbers[a] = int.Parse(Console.ReadLine());
}

for (int b = numbers.Length - 1; b >= 0; b --)
{
    Console.Write($"{numbers[b]} ");
}
