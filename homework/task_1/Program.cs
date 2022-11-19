// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    if (Ask.Length!=5 || Ask[0]=='-'){
        Console.WriteLine("Введите верное число!");
        return AskUser();
    }else{
        int op = int.Parse(Ask);
        return op;
    }
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

bool isPalindrom(double num){
    double num_length = Math.Floor(Math.Log10(num))+1;
    double first_num = Math.Floor(num/(Math.Pow(10, 4)));
    double second_num = Math.Floor((num/(Math.Pow(10, 3))%10));
    double fourth_num = Math.Floor((num%100)/10);
    double fifth_num = Math.Floor(num%10);
    if (first_num==fifth_num&&second_num==fourth_num){
        Console.WriteLine("True");
         return true;
    }else{
        Console.WriteLine("False");
        return false;
    }
}

isPalindrom(AskUser());