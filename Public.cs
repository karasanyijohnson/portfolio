using System; 
namespace Class
{
    class Class
    {
static void Main(string[] args)
           {
var object1 = new Calculate();
string Opera;
Console.WriteLine("Enter first number:");
 var num1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
 var num2 =Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("enter an operator");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");

 Opera=Console.ReadLine();

 
 if(Opera=="+")
 {
  object1.Addition(num1,num2);
 Console.WriteLine("the sum of {0}and{1} is equal to{2}",num1,num2,object1.Addition(num1,num2));
 }
 else if(Opera=="-")
 {
object1.substract(num1,num2);
 Console.WriteLine("the difference of {0}and{1}is equal to{2}",num1,num2,object1.substract(num1,num2));
 }
 else if(Opera=="*")
 {
object1.multiply(num1,num2);
 Console.WriteLine("the product of {0}and{1}is equal to{2}",num1,num2,object1.multiply(num1,num2));
 } 
 else if(Opera=="/")
 {
object1.divide(num1,num2);
 Console.WriteLine("the division of {0}and{1}is equal to{2}",num1,num2,object1.divide(num1,num2));
 }
 else
 {
Console.WriteLine("wrong calculation");
 }
 
Console.ReadKey();
           }
    }

}
    

   