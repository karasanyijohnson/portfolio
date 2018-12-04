using System; 
namespace Class
{
    class Calculate
    
    {
        public double Addition(double num1,double num2)
        {
    return (num1 + num2);
    
        }
        public double substract( double num1,double num2)
        {
 return(num1 - num2);
        }
        public double divide( double num1, double num2)
        {
            if(num2 !=0)
            return(num1/num2);
            else
            {
              throw new Exception("imposible");  
            }
        }
        public double multiply( double num1, double num2)
        {
return(num1*num2);
        }
    }

}
