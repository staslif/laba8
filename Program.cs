Console.WriteLine("введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y");
int y = Convert.ToInt32(Console.ReadLine());
try
{
    int z = x / y;
    Console.WriteLine(z);
}
catch
{
    Console.WriteLine("исключение:");
}
try
{
    int z = x / y;
    if (x == 0)
    {
        throw new Exception("результат в переменной z будет нулевым");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}