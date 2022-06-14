Console.WriteLine("Введите проверяемое число");
int userNum = int.Parse(Console.ReadLine());
int i = 2;

while (userNum > 0)
{
    if (userNum % i == 0)
    {
        Console.WriteLine($"Число {userNum} - не является простым");
        break;
    }
    else
    {
        Console.WriteLine($"Число {userNum} является простым");
    }

    break;
}

