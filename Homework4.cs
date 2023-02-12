namespace Lecture4;
/*class Program
{
 static void Main(string[] args){
    Console.WriteLine("-------Question1------");
         Console.WriteLine("Please input the first num:");
    int a=Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("Please input the second num:");
    int b=Convert.ToInt16(Console.ReadLine());
   
        int largest=0;
           if(a>b) {
            largest=a;
           }
      
       if(b>a) {
            largest=b;
        
    }
    Console.WriteLine("a =" + " " + a + ", " + "b =" + " " + b);
    Console.WriteLine("The largest number is: {0}",largest);
 }
}*/

  class Program4
{
static void Main(string[] args){

    static void pattern(int N,string shape){
    int i,j,k; 
    if(shape=="left"){
   
       for(i=1;i<=N;i++)
       {
    	for(j=1;j<=i;j++)
    	   Console.Write("*"); 
    	Console.Write("\n"); 
       }
      }
    else if(shape=="right"){
    
     for (i=1;i<= N;i++)  
         {  
            for (j = 1; j <= N-i; j++)  
            {Console.Write(" ");}  
            for (k = 1; k <= i; k++)  
            {  Console.Write("*");}  
            Console.WriteLine("");  }  
            Console.ReadLine();}
    }
   int N; 
   string shape; 
        Console.Write("-------Question 2-------");
        Console.Write("Assign an integer value to N: ");
        N= Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Input shape: ");
        shape= Console.ReadLine(); 
        Console.Write("N is: "+N+"; shape is "+shape+"\n"); 
        pattern(N,shape); 
}
}