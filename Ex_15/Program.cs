/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите число, обозначающее день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<8 && num>0)
{
    if (num>5)
    {
        Console.WriteLine("Введеное число обозначает долгожданный выходной день");
    }
    else
    {
        Console.WriteLine("Введеное число обозначает тяжелые трудовые будни");
    }
}
else
{
    if (num>7)
    {
        Console.WriteLine("Куда еще столько дней в неделе?");
    }
    else
    {
        Console.WriteLine("Такого не может быть!");
    }
}
