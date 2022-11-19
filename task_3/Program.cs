// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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

string[] Players = new string[10];