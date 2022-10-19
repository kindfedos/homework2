Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 100)
{
    Console.WriteLine("Третье цифры нет");
    return;
}
int thirdValue = FindThirdValue(num);
Console.WriteLine($"третья цифра в числе - {thirdValue}");


int FindThirdValue( int number)
{
    int third = number;
    while((number/100) > 0)
    {
        third = number % 10;
        number = number / 10;
        }
        return third;
}



















