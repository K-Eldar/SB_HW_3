Console.WriteLine("Доброе пожаловать в Blackjack, \nвведите количество карт на руках: ");
int handCards = int.Parse(Console.ReadLine());
int allNominal = 0;
Console.WriteLine("Далее вам будет необходимо вести номинал своих карт, \nдля карт картинок следует принять \nобозначения латинскими буквами: \nВалет = J, Дама = Q, Король = K, Туз = T");

for (int i = 1; i <= handCards; i++)
{
    Console.Write($"Введите номинал {i}-й карты: ");


    string cardNominal = Console.ReadLine();


    switch (cardNominal)
    {
        case  "2":
            allNominal += 2;
            break;
        case "3":
            allNominal += 3;
            break;
        case "4":
            allNominal += 4;
            break;
        case "5":
            allNominal += 5;
            break;
        case "6":
            allNominal += 6;
            break;
        case "7":
            allNominal += 7;
            break;
        case "8":
            allNominal += 8;
            break;
        case "9":
            allNominal += 9;
            break;
        case "10":
        case "J":
        case "Q":
        case "K":
        case "T":
            allNominal += 10;
            break; 
    }
}
Console.WriteLine($"Сумма карт на руках: {allNominal}");

