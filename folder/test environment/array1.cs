// Test of arrays 
//
Console.WriteLine("Input a number from 1 to 10");
int num = int.Parse(Console.ReadLine());
int countWrongInput = 0;
bool isValid = false;

while (num < 1 || num > 10)
{
    countWrongInput++;
    if (countWrongInput > 5)
    {
        Console.WriteLine("Too many wrong attempts...");
        break;
    }
    Console.WriteLine("Wrong input");
    Console.WriteLine("Input a number from 1 to 10");
    num = int.Parse(Console.ReadLine());
}

if (!(countWrongInput > 5))
{
    int[] numbers = new int[num];
    for (int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = a + 1;
    }
    for (int b = 0; b < numbers.Length; b ++)
    {
        Console.Write($"{numbers[b]} ");
    }
    Console.WriteLine();
    Console.WriteLine("EXIT");
}
else
{
    Console.WriteLine("EXIT WITH ERROR");
}
