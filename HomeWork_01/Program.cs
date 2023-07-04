Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
    Console.WriteLine("Число № 1 больше числа № 2");
else if (a == b)
    Console.WriteLine("Число № 1 равно числу № 2");
else
    Console.WriteLine("Число № 2 больше числа № 1");