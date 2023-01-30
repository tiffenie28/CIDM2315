namespace Lecture2;
class Program2
{
    static void Main(string[] args){
         Console.WriteLine("Please input the first num:");
    int a=Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("Please input the second num:");
    int b=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the third num:");
    int c=Convert.ToInt16(Console.ReadLine());
        int smallest=0;
        if(a<b) {
        if(a<c) {
            smallest=a;
        }
    }
       if(b<a) {
        if(b<c) {
            smallest=b;
        }
    }
        if(c<a) {
        if(c<b) {
            smallest=c;
        }
    }
        Console.WriteLine("The smallest value is: {0}",smallest);
  }
}
