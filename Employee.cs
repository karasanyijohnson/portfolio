using System;

namespace Class
{
    class employee
    {
        public int empNum;
        public string empName;
        public string empType;
        public employee(int aId, string aName, string aType)
        {
            empNum = aId;
            empName = aName;
            empType = aType;
        }
        public double payment()
        {
            if(empType == "M-E")// for monthly employee
            {
                double a,b,c;
                int grossSalary=800000;// his grosssalary
                a=(grossSalary*18)/100;//after paying tax
                b=grossSalary-a;//net salary
                c=b*3/100;// amount he pay to sacial security saving
                return (b-c);// this is the overall salary after paying all
            }
            else if(empType == "T-E")// for temporal employee who is paid according hours he/she works
            {
                double d;
                int grossSalary=50000;// his salary
                d=grossSalary*18/100;// after paying tax
                return (grossSalary-d);// amount he will remain with after paying taxi
            } 
            //for evening employee who is paid according to hours worked plus bonus
            else{
                double e,f,g;
                int grossSalary=25000;// amount paid per hour during a month
                e=(grossSalary*18/100);// when he pays a tax
                f=grossSalary-e;//his net salary
                g=(f*0.15)/100;// bonnus on hours worked
                return (g+f);// overall salary  
            }           
        }
        static void Main(string[] args)
        {
            employee employee1 = new employee(1, "bruno", "M-E");
            employee employee2 = new employee(2, "Joyce", "M-E");
            employee employee3 = new employee(3, "Derick", "M-E");
            employee employee4 = new employee(4, "queen", "M-E");
            employee employee5 = new employee(5, "Obama", "T-E");
            employee employee6 = new employee(6, "David", "T-E");
            employee employee7 = new employee(7, "kellen", "T-E");
            employee employee8 = new employee(8, "yusta", "T-E");
            employee employee9 = new employee(9, "Emmanuel", "E-E");
            employee employee10 = new employee(10, "Eric", "E-E");
            employee employee11 = new employee(11, "chan", "E-E");
            employee employee12 = new employee(12, "francis", "E-E");
            Console.WriteLine("THE SALARY OF THIS EMPLOYEE IS:");
            Console.WriteLine(employee1.payment());
           }
    }
}
