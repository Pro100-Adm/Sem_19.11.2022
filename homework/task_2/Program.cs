// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using pointNamespace;

double AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
        double op = double.Parse(Ask);
        return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

Point a = new Point(AskUser(), AskUser(), AskUser());

Point b = new Point(AskUser(), AskUser(), AskUser());

Console.WriteLine(a.GetDistance(b));


