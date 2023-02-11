Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());//sisestatakse sümbol

Console.WriteLine("Enter a:");
int firstNumb = Int32.Parse(Console.ReadLine());//sisestatakse number
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)// valib tehte
{
    case '+':
        Addition(firstNumb, secondNum); break;
    case '-':
        Subtraction(firstNumb, secondNum); break;
    default: Console.WriteLine("invalid operator");
        break;
}

static void Addition(int a, int b)//int näitab mis tüüpi peavad andmed olema
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}
static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}
