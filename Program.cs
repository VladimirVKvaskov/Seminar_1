//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
/*
Console.Clear();

Console.Write("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());   

int max = a;
int min = b;

if(a > b) max = a;
if(b > a) max = b;

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();


Console.Write("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());   

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Clear();

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());                      
 
if (a % 2 == 0)
{
    Console.WriteLine("четное число");
           
}
else
{
    Console.WriteLine("нечетное число");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

    while(count < a+1)

    {   
        if (count % 2 == 0)
        Console.WriteLine(count);
        count = count + 1;
    }
*/

