using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class People
        {
            int age;
            int height;
            string name;
            string lastName;
        }

        static void Main(string[] args)
        {
            int a = 20;
            //Console.WriteLine("enter numb:");
            //string tmp = Console.ReadLine();
            //int b = int.Parse(tmp); //преобразование строки в число
            //int c = Convert.ToInt32(tmp);//преобразование строки в число

            //if( b > 10)
            //{
            //    Console.WriteLine( ">10 ");
            //}
            //else if(b > 5)
            //{

            //}
            //else if(b > 5)
            //{

            //}

            //Console.WriteLine(b +b);
            //Console.WriteLine(c +c);
            //Begin10();
            //Begin18();
            //If5();
            //MyFunction( a: 10, userName : "Вася");
            //MyFunction( 10, "Вася222");
        }
        
        
        
        static void If5()
        {
            Console.WriteLine("Введите первое число: ");
            string A = Console.ReadLine();

            int a = int.Parse(A);

            Console.WriteLine("Введите второе число:");
            A = Console.ReadLine();

            int b = int.Parse(A);

            Console.WriteLine("Введите третье число:");
            A = Console.ReadLine();

            int c = int.Parse(A);
            int pol = 0;
            int otr = 0;

            if (a > 0)

            {
                pol++;

            }
            if (b > 0)

            {
                pol++;

            }
            if (c > 0)

            {
                pol++;

            }
            if (a < 0)

            {
                otr++;

            }
            if (b < 0)

            {
                otr++;


            }
            if (c < 0)

            {
                otr++;

            }
            Console.WriteLine($"Pol: {pol}  Otr: {otr}");


        }
        static void Begin10()
        {
            Console.WriteLine("Enter a");
            string A = Console.ReadLine();

            int a = int.Parse(A);

            int V = a * a * a;
            //Math.Sqrt(V)
            int S = 6 * a * a;

            Console.WriteLine("V : " + V);
            Console.WriteLine("S : " + S);
        }

        static void Begin18()
        {
            Console.WriteLine("Enter a");
            string otrezok = Console.ReadLine();
            int a = int.Parse(otrezok);

            Console.WriteLine("Enter c");
            otrezok = Console.ReadLine();
            int c = int.Parse(otrezok);

            Console.WriteLine("Enter b");
            otrezok = Console.ReadLine();
            int b = int.Parse(otrezok);


            



            Console.WriteLine("Proizvedenye: " + (c-a) * (b-c));
            





        }

        static void MyFunction(int a, string userName)
        {

            Console.WriteLine("Hello," + userName );
            Console.WriteLine(a);
        }
    }
}
