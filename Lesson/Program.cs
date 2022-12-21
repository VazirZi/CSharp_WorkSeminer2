//=========================Задача_1=========================

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