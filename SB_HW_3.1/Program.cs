Console.WriteLine("Введите проверяемое число");
int userNum = int.Parse(Console.ReadLine());

if (userNum % 2 == 0)
{
    Console.WriteLine($"Введеное вами число: {userNum} - четное");
}
else
{
    Console.WriteLine($"Введеное вами число: {userNum} - нечетное");
}
Console.ReadKey();
