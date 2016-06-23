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
            string[] stringArray = new string[] { "Entry", "Junior", "Mid-level", "Professional", "Senior"};
            while (true)
            { 
            Console.WriteLine("kokia darbuotojo darbo patirtis");

                              string line = Console.ReadLine();
            int choise;
            int.TryParse(line, out choise);
                if (choise == 0)
                {
                    Console.WriteLine(stringArray[0]);
                                   }
                else if (choise <0)
                {
                    Console.WriteLine("Patirtis negali buti mazesne nei 0 arba didesne nei 100");
                }
               else if (choise >100)
                {
                    Console.WriteLine("Patirtis negali buti mazesne nei 0 arba didesne nei 100");
                }

                else if (choise > 0 && choise < 2)
            {
                Console.WriteLine(stringArray[1]);
            }

            else if (choise >= 2 && choise < 4)
            {
                Console.WriteLine(stringArray[2]);
            }

            else if (choise >= 4 && choise < 6.5)
            {
                Console.WriteLine(stringArray[3]);
            }

            else if (choise >= 6.5)
            {
                Console.WriteLine(stringArray[4]);
            }
                             else
            {
                Console.WriteLine("Ivestas blogas argumentas. Ivesti galima tik skaiciu");
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
