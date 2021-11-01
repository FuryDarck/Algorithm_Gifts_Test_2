using System;
using System.Diagnostics;

namespace Algorithm_Gifts
{
    class Program
    {
       static void OneTheme()
        {
            var p = 0;
            var a1 = 0;
            var a2 = 0;
            var a3 = 0;
            var a4 = 0;
            var i = 0;
            string a = "";
            string[] question = new[] {"Q1", "Q2", "Q3", "Q4", "Q5"};
            string[] massA1 = new[] {"a1", "b1", "c1", "d1"};
            string[] massA2 = new[] {"a2", "b2", "c2", "d2"};
            string[] massA3 = new[] {"a3", "b3", "c3", "d3"};
            string[] massA4 = new[] {"a4", "b4", "c4", "d4"};

            while (i != question.Length)
            {
                if (p == 1)
                {
                    p = 0;
                    i++;
                    if (i < question.Length)
                    {
                        Console.WriteLine(question[i]);
                        a = Console.ReadLine();
                    }else break; 
                }
                else
                {
                    Console.WriteLine(question[i]);
                    a = Console.ReadLine();
                }

                switch (a)
                {
                    case "1":
                        a1++;
                        p = 1;
                        break;

                    case "2":
                        a2++;
                        p = 1;
                        break;

                    case "3":
                        a3++;
                        p = 1;
                        break;

                    case "4":
                        a4++;
                        p = 1;
                        break;
                    default:
                        Console.WriteLine("Ne vernoe znachenie");
                        p = 0;
                        break;
                }
            }

            if (a1 > a2 & a1 > a3 & a1 > a4)
            {
               Console.WriteLine(massA1[new Random().Next(0, massA1.Length)]); 
            }else if (a2 > a1 & a2 > a3 & a2 > a4)
            {
                Console.WriteLine(massA2[new Random().Next(0, massA2.Length)]);
            }else if (a3 > a1 & a3 > a2 & a3 > a4)
            {
                Console.WriteLine(massA3[new Random().Next(0, massA3.Length)]);
            }else if (a4 > a1 & a4 > a2 & a4 > a3)
            {
                Console.WriteLine(massA4[new Random().Next(0, massA4.Length)]);
            }
            
            
            
        }

        
        static void Main(string[] args)
        {
            
            
            int a = 1;
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            while (a == 1)
            {
                switch (d)
                {
                    case 1:
                        OneTheme();
                        a = 0;
                        break;
                    case 2:
                        OneTheme();
                        a = 0;
                        break;
                    case 3:
                        OneTheme();
                        a = 0;
                        break;
                    case 4:
                        OneTheme();
                        a = 0;
                        break;
                    default:
                        Console.WriteLine("Ne vernoe znachenie");
                        d = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
        }
    }
}