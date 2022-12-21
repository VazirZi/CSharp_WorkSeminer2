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