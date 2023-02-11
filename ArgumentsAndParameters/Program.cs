
Console.WriteLine("Enter something");
string userInput = Console.ReadLine();//salvestan sõna maha lugemiseks. nimetan sisestatud sõna userInput-iks

PrintAnyWord(userInput);//funktsiooni kirjutasin, et sisestan argumendi (userInput)

static void PrintAnyWord(string anyString)//loon funktsiooni PrintAnyWord; anyString - parameeter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}