//VAR 12
//Высокий уровень/задание 1.1
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());
double G = ((Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y))) / (Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5));
Console.WriteLine($"G = {G}");
//Высокий уроыень/задание 1.2
Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());
if(a >= b)
{
    double x = Math.Floor(a / b);
    Console.WriteLine($"На отрезке a помешается отрезков b: {x}");
} else
{
    Console.WriteLine("отрезок b меньше отрезка a");
}