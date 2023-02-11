// allahindluse summa < 10 - allahindlus 1%
//summa(total) >= 10 && total < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());//kasutaja sisestatu peab olema arv

double discount = CalculateDiscount(userInput);//loon vahemälus double tüüpi vahemälus

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total)//CalculateDiscount on minu poolt antud nimi. int total ei ole double total
{
    if(total < 10)
    {
        return 1;//1-5-10 on protsendid, mis jõuavad double-sse ja double kasutab discountis returni väärtust
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)//CalculateNewTotal on minu poolt välja mõeldud nimi. double total ei ole int total.
{
    double result = total - (total * discount) / 100;
    return result;
}