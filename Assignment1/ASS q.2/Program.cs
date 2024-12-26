using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_q._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, ch;
            Console.WriteLine("entr num1");


               num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("entr num2");
            num2 =int.Parse(Console.ReadLine());
            do
            {
            Console.WriteLine("1:adddtion / 2:subtraction /3.multiplication /4.division");            
                ch = int.Parse(Console.ReadLine());
                switch (ch) {
                    
                    case 1:

                        Console.WriteLine($"num1 + num2 ={num1 + num2}");
                        break;

                        case 2:

                        Console.WriteLine($"num1 -num2={num1 - num2}");
                        break;

                    case 3:

                        Console.WriteLine($"num1 * num2 ={num1 * num2}");
                        break;

                    case 4:

                        Console.WriteLine($"num1 / num2 ={num1/num2}");
                        break;


                        default: Console.WriteLine("wrong choice");
                        break;
                }





            }
            while (ch>=4);





        }
    }
}
