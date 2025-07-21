//
string[] inputString = Console.ReadLine().Split().ToArray();
string[] reverseString = inputString.Reverse().ToArray();

for (int a = 0; a < reverseString.Length; a ++)
{
    Console.Write($"{reverseString[a]} ");
}
