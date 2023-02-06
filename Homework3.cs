namespace Lecture3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Question 1-----");
        Console.WriteLine("Input an integer:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
   if (number < 2)
            {
                Console.WriteLine("N is non-prime");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("N is prime");
            }
            else
            {
                Console.WriteLine("N is non-prime");
            }
        }
} 

class Program2
{
    static void Main(string[] args)
 {
    Console.WriteLine("-----Question 2-----");
    for(int row = 0; row<5; row++){
    for(int col = 0; col<5; col++)
    {
        Console.Write('#');
    }
    Console.WriteLine("");
}
}
}
class Program3
{
   static void Main(string[] args)
  {
    Console.WriteLine("-----Question 3-----");
    for(int row = 0; row<5; row++){
    for(int col = 0; col<5; col++)
    {
        if(row>=col)
            Console.Write('*');
    }
    Console.WriteLine("");
}
  }
}
  class Program4
{
   static void Main(string[] args)
  {
    Console.WriteLine("-----Bonus(almsot there)-----");
    int i,j,k,rows;
   Console.Write("Assign an int value to N : ");
   rows= Convert.ToInt32(Console.ReadLine());   
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=rows-i;j++)
   {
    Console.Write(" ");
   }
   for (k = 1; k <= i; k++)
    {
	Console.Write("{0}",j++);
    }
    Console.Write("\n");
	
   }
  }
}