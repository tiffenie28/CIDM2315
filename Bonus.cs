namespace Bonus;
class Program
{
    static void Main(string[] args)  
{
    int chk_year;
    Console.Write("Please input a year:\n");
    chk_year= Convert.ToInt32(Console.ReadLine());
    if ((chk_year % 400) == 0)
 Console.WriteLine("{0} is a leap year.\n", chk_year);
    else if ((chk_year % 100) == 0)
 Console.WriteLine("{0} is not a leap year.\n", chk_year);
    else if ((chk_year % 4) == 0)
 Console.WriteLine("{0} is a leap year.\n", chk_year);
    else
 Console.WriteLine("{0} is not a leap year.\n", chk_year);
}
}