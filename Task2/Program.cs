int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
             break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }

    }
    return result;
}

int number = GetNumber("Введите число");
if (number<100)
    Console.WriteLine("Третьей цифры нет");
else if (number<1000)
    {
    int thirdNumber = number / 100;
    Console.WriteLine("Третья цифра {0}",thirdNumber);}
else {
    int thirdNumber = (number % 1000) /100;
    Console.WriteLine("Третья цифра {0}",thirdNumber);}