Console.WriteLine("Введите проверяемое число");
int userNum = int.Parse(Console.ReadLine());

int N = userNum - 1;
bool result = true;
int i = 2;

while (1 < N)
{
        if (N % i == 0)
        {
            result = false;
            i++;
        }
        if (result) Console.WriteLine("Введенное число не является простым");
        else Console.WriteLine("Введенное число является простым");
    break;
};
