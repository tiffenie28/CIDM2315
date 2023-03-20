namespace Lecture8;

 
class Customer{
   

 private int cus_id;
 public string cus_name;
 public int cus_age;
 public Customer(int id, string name, int age) {
   
     cus_id = id;
     cus_name = name;
     cus_age = age;
 }
 public void ChangeID(int new_id) {
     cus_id = new_id;
 }
  
 public void printInfo(){
   
     Console.WriteLine("Customer: "+cus_id+" ,name : "+cus_name+", age : "+cus_age);
 }
}


    
    class Program{
    static void Main(string[] args){
    
          
    Customer cust1 = new Customer(110, "Alice", 28);
    cust1.printInfo();
    Customer cust2 = new Customer(111, "Bob", 30);
    cust2.printInfo();
    cust1.ChangeID(220);
    cust2.ChangeID(221);
    cust1.printInfo();
    cust2.printInfo();
    }
    }
/*public class HelloWorld
{
    public static void Main(string[] args)
    {
 
    {
        CustAge alice = new CustAge(28,"Alice");
        CustAge bob = new CustAge(30, "Bob");
        //use bob as objCust input
        alice.CompareAge(bob);
       
    }

    }
class CustAge{
    public int cus_age {get;set;} = 0;
    public string cus_name  {get;set;}= string.Empty;
    public CustAge(int cus_age, string cus_name){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }

 
 public void CompareAge(CustAge objCust){
        Console.WriteLine($"Current name is: {cus_age}");
        if(this.cus_age <= objCust.cus_age){
            Console.WriteLine($"{objCust.cus_name} is older");
        }else{
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
}
    }*/

 

