double[] inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
double tempNumber = 0;

for (int a = 0; a < inputNumbers.Length; a++)
{
    tempNumber = Math.Round(inputNumbers[a], 0, MidpointRounding.AwayFromZero);
    if (tempNumber == -0)
    {
        tempNumber = 0;
    }
    Console.WriteLine($"{inputNumbers[a]} => {tempNumber}");
}
