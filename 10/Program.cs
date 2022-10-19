Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

 
for (int i = 1; i < 3 && (num <= 100 | num > 999); i++)
{
Console.Write( " Это не трёхзначное число! ");
num = Convert.ToInt32(Console.ReadLine());
}

num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");
