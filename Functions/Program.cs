Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();//kirjeldan andmetüüpi, mida kasutaja kirjutab

if(userChoice == "in") // sean tingimuse millist funktsiooni kasutatakse
{
    PrintHallo(); // siin kutsun välja funktsiooni
}
else
{
    PrintGoodbye();
}




static void PrintHallo() //siin loon funktsiooni (function/method)
{
    Console.WriteLine("Hallo, world!"); //siin loon sisu funktsioonile
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, alligator.");
}