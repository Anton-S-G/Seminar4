while (true) // true == true
{
Console.Write("Введите строку: ");
string text = Console.ReadLine()!;
if (text == "q")
{
    Console.WriteLine("[STOP]  Введена буква выхода 'q'");
break;
}

// Нужно проверить, что строчка text cостоит ТОЛЬКО
// из цифр
int number; // 0, если в строчке есть символы
// или само число
if (int.TryParse(text, out number)) // == true
{
// Console.WriteLine("Введенная строчка состоит из ЦИФР");
    int sum = 0; // 56 => 6+5
    while (number > 0)
    {
    sum += number % 10;
    number /= 10; // Избавляюсь от последней цифры
    }
        if (sum % 2 == 0)
            {
            Console.WriteLine("[STOP]  сумма цифр числа чётная");
            break;
            }
}

}