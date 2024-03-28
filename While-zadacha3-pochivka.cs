//this is a simple program that uses while loop
double neededMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());
bool spend = false; int count = 0; int countDay = 0;

while(true)
{
    string action = Console.ReadLine();
    double moveMoney = Double.Parse(Console.ReadLine());

    if (action == "save")
    {
        availableMoney += moveMoney;
        spend = false;
        countDay++;
        if (availableMoney >= neededMoney)
        {            
            Console.WriteLine($"You saved the money for {countDay} days.");
            break;
        }
    }
    if (action == "spend")
    {
        availableMoney -= moveMoney;
        if (availableMoney < 0)
        {
            availableMoney = 0;
        }
        countDay++;
        if (spend == true)
        {
            count++;
        }
        else
        {
            count = 1;
        }
        if (count == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{count}");
            break;
        }        
        spend = true;       
    }
}
