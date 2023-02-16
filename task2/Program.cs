// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите день недели: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.Write("понедельник");
}
if(number == 2)
{
    Console.Write("вторник");
}
if(number == 3)
{
    Console.Write("среда");
}
if(number == 4)
{
    Console.Write("четверг");
}
if(number == 5)
{
    Console.Write("Пятница");
}
if(number == 6)
{
    Console.Write("суббота");
}
if(number == 7)
{
    Console.Write("воскресение");
}
if(number < 1)
{
    Console.Write("Неверно");
}
if(number > 7)
{
    Console.Write("неверно");
}