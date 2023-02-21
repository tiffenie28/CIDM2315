namespace Lecture5;
class Program
{
static void Main (string[] args) {
    Console.WriteLine("Please input two integers: ");
    int integer1 = getInteger();
    int integer2 = getInteger();
    int largest = larg(integer1, integer2);
    Console.WriteLine("a =" + " " + integer1 + "; " + "b =" + " " + integer2);
    Console.WriteLine("The largest number is: " + larg(integer1, integer2));
    }


static int getInteger(){
    string str_input = Console.ReadLine();
    int int_input = Convert.ToInt16(str_input);
    return int_input;
}
static int larg(int integer1, int integer2){
    
     
        if (integer1>integer2)
        {
            return integer1;
        }
        else
        {
            return integer2;
        }
    
}
}
class ProgramQ2
{
void main()
{
    int integer1 = Convert.ToInt32(Console.ReadLine());
    int integer2 = Convert.ToInt32(Console.ReadLine());
    int integer3 = Convert.ToInt32(Console.ReadLine());
    int integer4 = Convert.ToInt32(Console.ReadLine());

    int result = Large(integer1, integer2, integer3, integer4);
    Console.WriteLine("The largest number is: " + result);
}  

}

static int Large(int integer1, int integer2, int integer3, int integer4){
    int max1= Largest (integer1,integer2);
    int max2= Largest (integer3,integer4);

    int result = Largest(max1,max2);
    return result;
}


class ProgramQ3
{
static void Main()
{
    createAccount();
}
public static bool checkAge(int birth_year)
{
        if ((2022 - birth_year) >= 18)
        return true;
        else
        return false;
}
public static void createAccount(){
Console.Write("Enter the userName: ");
string userName = Console.ReadLine();
Console.Write("Enter the password: ");
string password = Console.ReadLine();
Console.Write("Enter the password again: ");
string confirm_password = Console.ReadLine();
Console.Write("Enter your Birthyear: ");
int birth_year = Convert.ToInt32(Console.ReadLine());
        if (checkAge(birth_year))
    {
        if(password==confirm_password)
Console.WriteLine("Account is created Successfully.");
        else
Console.WriteLine("Wrong Password.");

    }
        else
    {
Console.WriteLine("Could not create an account.");
}
}
}