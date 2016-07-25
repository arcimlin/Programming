using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND3
{
    class Program

    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter year number:");
                string year = Console.ReadLine();
                double fullyear;
                if (!double.TryParse(year, out fullyear))
                {
                    if (year == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Invalid.Please enter the number");
                    continue;
                }
                Console.WriteLine("Please enter month number:");
                string month = Console.ReadLine();
                double fullmonth;
                if (!double.TryParse(month, out fullmonth)) 
                {
                    if (month == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Invalid.Please enter the number");
                    continue;
                }
                    {

                        if (fullmonth < 1 || fullmonth > 12)
                        {
                            Console.WriteLine("There is only 12 months in a year");
                        }

                        else if (fullmonth == 1 || fullmonth == 3 || fullmonth == 5 || fullmonth == 7 || fullmonth == 8 || fullmonth == 10 || fullmonth == 12)
                        {
                            Console.WriteLine(year + "-" + month + " " + "has 31 days");
                        }
                        else if (fullmonth == 4 || fullmonth == 6 || fullmonth == 9 || fullmonth == 11)
                        {
                            Console.WriteLine(year + "-" + month + " " + "has 30 days");
                        }
                        else if (fullmonth == 2 || fullyear % 4 == 0)
                        {
                            Console.WriteLine(year + "-" + month + " " + "has 29 days");
                        }
                    else if (fullmonth == 2 || fullyear % 4 != 0)
                    {
                        Console.WriteLine(year + "-" + month + " " + "has 28 days");
                    }
                    Console.WriteLine("Do you want to continue?");
                        string answer = Console.ReadLine();
                        {
                            if (answer == "n")
                            {
                                break;
                            }
                            else if (answer == "y")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }




    


