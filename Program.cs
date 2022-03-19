Console.WriteLine("Введите число");
string number = Console.ReadLine();
ThirdNumber(number);

void ThirdNumber(string number1)
{
    if (number1.Length <= 2)
    {
        Console.WriteLine(number1 + " >> Третьей цифры нет");
    }
    else {
        Console.WriteLine(number1 + " >> " + number1[2]);
    }
}