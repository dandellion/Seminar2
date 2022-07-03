int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result>=1 && result<=7)
             break;
            else {
            Console.Clear();
            Console.WriteLine("Вы ввели некорректное число. Введите корректное число.");
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
if (number == 6 || number == 7)
     Console.WriteLine("Это выходной");
else 
    Console.WriteLine("Это не выходной");
