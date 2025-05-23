//
int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool isCondensed = false;

if (inputArray.Length == 1)
{
    Console.WriteLine(inputArray[0]);
    isCondensed = true;
}

while (!isCondensed)
{
    int[] temp = new int[inputArray.Length - 1];
    for (int a = 0; a < temp.Length; a ++)
    {
        temp[a] = inputArray[a] + inputArray[a + 1];
    }
    if (temp.Length == 1)
    {
        isCondensed = true;
        Console.WriteLine(temp[0]);
    }
    else
    {
        inputArray = temp;
    }
}
//
