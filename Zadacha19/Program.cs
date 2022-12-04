Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз ");
    return;
}

int n5 = num % 10;
int n4 = num / 10 % 10;
int n2 = num / 1000 % 10;
int n1 = num / 10000 % 10;
if (n5 == n1 && n4 == n2)
{
    Console.WriteLine("Да, это палиндром ");
}
else
{
    Console.WriteLine("Нет, это НЕ палиндром ");
}
