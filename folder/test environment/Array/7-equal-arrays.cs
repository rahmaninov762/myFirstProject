//
int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool areEqual = true;
int sum = 0, element = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        sum += firstArray[i];
    }
    else
    {
        element = i;
        areEqual = false;
        break;
    }
}
if (areEqual)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
else
{
    Console.WriteLine($"Arrays are not identical. Found difference at {element} index");
}
