
List<int> numbersList = new List<int>();

for (int a = 0; a < 10; a++)
{
    Console.WriteLine($"add number {a + 1} in the list");
    numbersList.Add(int.Parse(Console.ReadLine()));
}

foreach (int x in numbersList)
{
    Console.Write($"{x} ");
}

int[] stringArray = new int[numbersList.Count];
stringArray = numbersList.ToArray();

//for (int i = 0; i < stringArray.Length; i++)
//{
//   stringArray[i] = numbersList[i];
//}
Console.WriteLine();
for (int b = 0; b < stringArray.Length; b++)
{
    Console.Write($"{stringArray[b]} ");
}
List<int> secondList = new List<int> { 5, 6, 7 };
numbersList.AddRange(secondList);

Console.WriteLine();
foreach (int x in numbersList)
{
    Console.Write($"{x} ");
}
