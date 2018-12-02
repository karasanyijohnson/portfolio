using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe("", 3, 6, 8);

            Console.WriteLine("Enter your employe_name");
            employe1.employe_name = Console.ReadLine();
            Console.WriteLine("Enter you id");
            employe1.id = Convert.ToInt32(Console.ReadLine());

            if ((employe1.employe_name != null) && (employe1.id != null))
            {

                Console.WriteLine("please select type of employeloyment");
                Console.WriteLine("************************************");


                Console.WriteLine("1.Montnly employeloyee");
                Console.WriteLine("2.Temorary employeloyee");
                Console.WriteLine("3.Evenning employeloyee");

                employe1.type = Convert.ToInt32(Console.ReadLine());

                if (employe1.type == 1)
                {

                    employe1.salary(employe1.gross);









                }

                else if (employe1.type == 2)
                {

                    employe1.salary(employe1.hours, employe1.hour_salary);






                }


                else if (employe1.type == 3)
                {


                    employe1.salary(employe1.hours, employe1.hour_salary, employe1.bonus, employe1.net_before_bonus);









                }

                else Console.WriteLine(" invalid type of employeloyment");




                Console.ReadLine();
            }

            else Console.WriteLine(" ivalid ID or employe_name");




        }





    }
}
 
    class Employe
{
    public string employe_name;
    public int id;
    public int type;
    public int gross;
    public int net;
    public int hours;
    public int hour_salary;


    public int gross1;
    public int bonus;
    public int net_before_bonus;




    public Employe(string aEmploye_name, int aId, int atype, int aGross)

    {
        employe_name = aEmploye_name;
        id = aId;
        type = atype;
        gross = aGross;


    }


    public void salary(int gross)
    {






        Console.WriteLine("please inter montly salary");

        gross = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("employeloyee employe_name : " + employe_name);
        Console.WriteLine("employeloyee ID : " + id);
        Console.WriteLine("type of  employeloyement : Montly employeloyement");
        Console.WriteLine("gross salary: " + gross);
        Console.WriteLine("net salary " + (gross - (gross * 21) / 100));








    }


    public void salary(int hours, int hour_salary)
    {

        Console.WriteLine("Please inter your total  number of days you work");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please inter your daily salary");

        hour_salary = Convert.ToInt32(Console.ReadLine());


        gross = (hours * hour_salary);
        net = (gross - (gross * 18) / 100);

        Console.WriteLine("employeloyee employe_name : " + employe_name);
        Console.WriteLine("employeloyee ID : " + id);
        Console.WriteLine("type of  employeloyement : Temployeoray employeloyement");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross);
        Console.WriteLine("net salary" + net);

    }

    public void salary(int nights, int hour_salary, double bonus, int net_before_bonus)
    {
        Console.WriteLine("please inter  your total number of hours ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please inter  your one  hour salry ");

        hour_salary = Convert.ToInt32(Console.ReadLine());
        gross = (hours * hour_salary);
        bonus = ((gross * 0.15) / 100);


        net_before_bonus = (gross - ((gross * 18) / 100));
        net = Convert.ToInt32(net_before_bonus + bonus);


        Console.WriteLine("employeloyee employe_name : " + employe_name);
        Console.WriteLine("employeloyee ID : " + id);
        Console.WriteLine("type of  employeloyement : evening employeloyment");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross);
        Console.WriteLine("net salary: " + net);




    }

}



 
