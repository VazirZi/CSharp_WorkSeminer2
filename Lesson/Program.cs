//=========================Задача_1=========================

/*
int result (int n)              // описываем функцию для проверки ввода трехзначного числа
{
    if (n <= 99 || n > 999)
{
    while (n <= 99 || n > 999)
    {
        Console.Write("Введенное число не трехзначное! Введите трехзначное число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}

return n;

}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = result(number);      // вызываем функцию проверки на ввод трехзначного числа

int res = (num - (((num / 100) * 100) + (num % 10)))/10;

Console.WriteLine($"Вторая цифра числа {num} = {res}");
*/

//=========================Задача_2=========================

/*
int thridNumber (int n)     // функция для получения третьей цифры введенного числа
{
    int d = 0;

    while (n >= 100)
    {
        d = n % 10;
        n = n / 10;
    }
    return d;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
int res = thridNumber(number);  // вызываем функцию для получения третьей цифры введенного числа

Console.WriteLine($"Третья цифра числа {number} = {res}");
}
*/

//=========================Задача_3=========================

/*
Console.Write("Введите число дня недели (1 = понедельник и т. д.): ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1 : Console.WriteLine($"Не выходной (понедельник ({number}))"); break;
    case 2 : Console.WriteLine($"Не выходной (вторник ({number}))"); break;
    case 3 : Console.WriteLine($"Не выходной (среда ({number}))"); break;
    case 4 : Console.WriteLine($"Не выходной (четверг ({number}))"); break;
    case 5 : Console.WriteLine($"Не выходной (пятница ({number}))"); break;
    case 6 : Console.WriteLine($"Выходной (суббота ({number}))"); break;
    case 7 : Console.WriteLine($"Выходной (воскресенье ({number}))"); break;
    default : Console.WriteLine("Нет такого дня"); break;
}
*/