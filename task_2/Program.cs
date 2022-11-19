// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    if (op==0){
        Console.WriteLine("Деление на 0!");
        return AskUser();
    }
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

double RootNum(double num, double power){
    Console.WriteLine(Math.Pow(num, 1/power));
    return Math.Pow(num, 1/power);
}

RootNum(AskUser(), AskUser());
