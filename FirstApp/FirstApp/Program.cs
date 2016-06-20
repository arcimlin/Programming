using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("kokia darbuotojo darbo patirtis");

            // int choise = Convert.ToInt32(Console.ReadLine());
            // if (choise == 0)
            string line = Console.ReadLine();
            int choise;
            int.TryParse(line, out choise);
            if (choise == 0)
            {
                Console.WriteLine("Entry");
            }

            else if (choise > 0 && choise < 2)
            {
                Console.WriteLine("Junior");
            }

            else if (choise >= 2 && choise < 4)
            {
                Console.WriteLine("Mid-level");
            }

            else if (choise >= 4 && choise < 6.5)
            {
                Console.WriteLine("Professional");
            }

            else if (choise >= 6.5)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }  

            //Darbuotojo vardas
            //string Name = "Lina";
            //string Surname = "Arcimaviciene";
            //int Age = 15;
            //double Salary = 40.50;
            //bool ShortTerm = true;
            //if (Age < 14)
            {
               // Console.WriteLine("vaikas");
            }
            //else if (Age >= 18 && Age < 60)
            {
                //Console.WriteLine("darbingas");
            }
            //else if (Age < 18)
            {
                //Console.WriteLine("paauglys");
            }
            //else
            {
               // Console.WriteLine("Senas");
            }
            //Console.WriteLine(Name + " " + Surname + Age + Salary);
            //Console.WriteLine(10 + 30);

            //Console.ReadLine();
        }
    }
}
