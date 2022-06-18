// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int A = prompt("Введите число A: ");
int B = prompt("Введите число B: ");

double result = Math.Pow(A, B);
System.Console.WriteLine($"{A} в натуральной степени {B} = {result}");

// или 

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int promt(string message)
{
    Console.Write(message);  
    string NumStr = Console.ReadLine();
    int num = int.Parse(NumStr);
    return num;
}

int numberA = prompt("Введите число A: ");
int numberB = prompt("Введите число B: ");

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"{numberA} в натуральной степени {numberB} = {exponentiation}");

