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
        if(op<=0){
            Console.WriteLine("Введите верное число!");
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

void CubeTable(double num){
    for(int i = 1; i<=num;i++){
        Console.WriteLine(Math.Pow(i,3));
    }
}

CubeTable(AskUser());