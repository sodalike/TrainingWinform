using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    struct Book
    {
        public string Name;
        public int Price;

        static Book()
        {
            Console.WriteLine("호출");
        }

        public void test()
        {
            Console.WriteLine("북 메소드");
        }
    }

    class Program
    {
        enum Week
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun,

        }
         
        static void Main(string[] args)
        {
            //Console.WriteLine("지옥으로 키티");
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            //Console.WriteLine("{0:X}", 100);

            //string inValue = Console.ReadLine();
            //Console.WriteLine("{0}",inValue);

            /*
            Week GoodDay;
            Week Today;

            GoodDay = Week.Fri;
            Today = Week.Thu;

            Console.WriteLine("GoodDay = {0}", GoodDay);
            Console.WriteLine("Today = {0}", Today);

            Console.WriteLine("GoodDay Index = {0}", (int)GoodDay);
            Console.WriteLine("Today Index = {0}", (int)Today);

            Console.WriteLine("Index = {0}", (int)Week.Mon);
            Console.WriteLine("Index = {0}", (int)Week.Tue);
            Console.WriteLine("Index = {0}", (int)Week.Wed);
            Console.WriteLine("Index = {0}", (int)Week.Thu);
            Console.WriteLine("Index = {0}", (int)Week.Fri);
            Console.WriteLine("Index = {0}", (int)Week.Sat);
            Console.WriteLine("Index = {0}", (int)Week.Sun);
            */
            Console.WriteLine("Main 시작");

            Book abook;
            abook.Name = "test";
            abook.Price = 100;
            abook.test();
            Book abook2;
            abook.Name = "test2";
            abook.Price = 200;
            abook.test();


        }
    }
}