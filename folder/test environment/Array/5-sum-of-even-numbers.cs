int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;

for (int a = 0; a < inputNumbers.Length; a++)
{
    if (inputNumbers[a] % 2 == 0)
    {
        sum += inputNumbers[a];
    }
}
Console.WriteLine(sum);
