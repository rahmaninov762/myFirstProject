int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumEven = 0;
int sumOdd = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] % 2 == 0)
    {
        sumEven += inputNumbers[i];
    }
    else
    {
        sumOdd += inputNumbers[i];
    }
}
Console.WriteLine(sumEven-sumOdd);
