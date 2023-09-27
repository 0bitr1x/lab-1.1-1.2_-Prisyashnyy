//учебник "сборник задач по программированию"/тема: Арифметические выражения/высокий уровень/вариант_12
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());
double G = ((Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y))) / (Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5));
Console.WriteLine($"G = {G:F2}");
//учебник "сборник задач по программированию"/тема: Программирование линейных алгоритмов/высокий уровень/вариант_12
Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());
double x = Math.Floor(a / b);
Console.WriteLine($"На отрезке a помешается отрезков b: {x}");
