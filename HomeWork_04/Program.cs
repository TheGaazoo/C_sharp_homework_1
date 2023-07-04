Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа в заданном диапазоне:");
for (int i = 1; i <= a; i=i+1) 
{
 if ((i%2)==0)
 Console.WriteLine(i);   
}   
