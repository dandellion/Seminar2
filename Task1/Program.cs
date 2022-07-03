int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result<1000 && result>99)
                break;
            else {
                Console.Clear();
                Console.WriteLine("Вы ввели не треззначное число. Введите корректное число.");
                }
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

int secondN = (number / 10) % 10;

Console.WriteLine("Полученное число {0}",secondN);