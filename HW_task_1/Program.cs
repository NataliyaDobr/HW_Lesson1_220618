// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = int.Parse(Console.ReadLine());

if (number_1>number_2)
{
    Console.WriteLine($"Первое число {number_1} больше, чем второе число {number_2}");
}
else
{
    Console.WriteLine($"Второе число {number_2} больше, чем первое число {number_1}");
}
if (number_1==number_2)
{
    Console.WriteLine($"Числа равны: {number_1} = {number_2}");
}