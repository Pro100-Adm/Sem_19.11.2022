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
    //if (op==0){
    //    Console.WriteLine("Невозможна точка с координатой 0!");
    //    return AskUser();
    //}
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

int Quarter(double x, double y){
    int quarter = 0;
    if (x>0 && y>0){
        quarter = 1;
    }
    else if(x>0 && y<0){
        quarter = 2;
    }
    else if(x<0 && y<0){
        quarter = 3;
    }
    else if(x<0 && y>0){
        quarter = 4;
    }
    Console.WriteLine("Четверть "+ quarter);
    return quarter;
}

//Quarter(AskUser(), AskUser());

double Distance(double x1, double y1, double x2, double y2){
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine("Расстояние между точками = " + distance);
    return distance;
}

Distance(AskUser(), AskUser(), AskUser(), AskUser());