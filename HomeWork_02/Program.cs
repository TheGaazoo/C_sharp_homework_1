
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
    Console.WriteLine("Число № 1 больше остальных чисел");
else if (a == b && a == c)
    Console.WriteLine("Все числа равны");
else if (b > a && b > c)
    Console.WriteLine("Число № 2 больше остальных чисел");
else
    Console.WriteLine("Число № 3 больше остальных чисел");