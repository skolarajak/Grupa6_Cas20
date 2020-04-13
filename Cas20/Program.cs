using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas20
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExplainSwitch();
            //ExplainWhile();
            //ExplainFor();
            //ExplainDo();
            //Test1();
            //Test2();
            Test3();
            Console.ReadKey();
        }

        static void Test3() {
            int i = 1;            do            {                i = i + 2;            } while (i <= 100);            Console.WriteLine("Vrednost i je {0}", i);        }

    static void Test2()
        {
            int a = 0;            for (int i = 1; i <= 10; i++)            {                a = a + i;                Console.WriteLine("I = {0}, A = {1}", i, a);            }            Console.WriteLine("Vrednost a je {0}", a);
        }

        static void Test1()
        {
            int i = 1;            while (i < 100)            {
                i++;            }
            Console.WriteLine("Vrednost i je {0}", i);        }

        static void ExplainDo()
        {
            int i = 1;
            Console.WriteLine("Pocetak WHILE petlje:");
            while (i > 1)
            {
                Console.WriteLine("Vrednost i je {0}", i);
                i++;
            }
            Console.WriteLine("Pocetak DO..WHILE petlje:");
            do
            {
                Console.WriteLine("Vrednost i je {0}", i);
                i++;
                if (i > 100)
                {
                    break;
                }
            } while (i > 1);
            Console.WriteLine("Petlja je zavrsena.");
        }

        static void ExplainFor()
        {
            Console.WriteLine("Pocetak petlje koja ide od 1 do 9:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Vrednost i je {0}", i);
            }
            Console.WriteLine("Pocetak petlje koja ide od 10 do 2:");
            for (int i = 10; i > 1; i--)
            {
                Console.WriteLine("Vrednost i je {0}", i);
            }
            Console.WriteLine("Pocetak ugnjezdjene petlje:");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++) 
                {
                    Console.WriteLine("I={0}, J={1}", i, j);
                }
            }
            Console.WriteLine("Petlja je zavrsena.");
        }

        static void ExplainWhile()
        {
            bool flag = false;
            int i = 1;

            while(flag == false)
            {
                Console.WriteLine("Vrednost i je {0}", i);
                i++;
                if (i >= 10)
                {
                    flag = true;
                }
            }
            Console.WriteLine("Petlja je zavrsena.");
        }

        static void ExplainSwitch()
        {
            int ocena = 3;
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                default:
                    Console.WriteLine("Ocena nije validna");
                    break;
            }
        }
    }
}
