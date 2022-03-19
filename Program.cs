Console.WriteLine("Введите число");
string number = Console.ReadLine();
ThirdNumber(number);

void ThirdNumber(string number1)
{
    if (number1.Length <= 2)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else {
        Console.WriteLine(number1[2]);
    }
}