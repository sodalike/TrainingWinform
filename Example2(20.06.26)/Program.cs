using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_20._06._26_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1
            double radius = 3.14;
            Console.WriteLine("radius의 형 : {0}", radius.GetType());
            Console.WriteLine("radius의 값 : {0}", radius.ToString());
            Console.WriteLine("radius의 값 : {0}", radius);

            Console.WriteLine();

            string name = "이효리";
            Console.WriteLine("name 형 : {0}", name.GetType());
            Console.WriteLine("name 값 : {0}", name.ToString());
            Console.WriteLine("name 값 : {0}", name);
            Console.WriteLine();

            Console.WriteLine("radius == name : {0}", name.Equals(radius));
            //2
            int intValue = 127;
            long longValue = intValue;

            Console.WriteLine("longValue = {0}", longValue);
            //3
            long longValue = 32727;
            int intValue = (int)longValue;

            Console.WriteLine("inValue = {0}", intValue);
            
            //3
            int aint = 0xFFFF;
            Console.WriteLine("{0:X8}", aint);
            aint = ~aint;
            Console.WriteLine("{0:X8}", aint);
            
            //4
            int aint = 0x12345678;
            Console.WriteLine("{0:X8}", aint);
            aint = ~aint;
            Console.WriteLine("{0:X8}", aint);
            aint = aint >> 4;
            Console.WriteLine("{0:X8}", aint);
            aint = aint << 4;
            Console.WriteLine("{0:X8}", aint);
            
            //5
            byte abyte1 = 0x3F;
            byte abyte2 = 0xC1;
            Console.WriteLine("AND : {0:x2}", abyte1 & abyte2);
            Console.WriteLine("OR : {0}", abyte1 | abyte2);
            Console.WriteLine("XOR : {0}", abyte1 ^ abyte2);
            
            //6
            bool abool = !true;
            Console.WriteLine("abool의 상태는" + (abool ? "참" : "거짓") + "일껄요?");

            int iNum = 100;
            if (iNum < 500) 
            {
                Console.WriteLine("500보다 작습니다.");
            }
            else
            {
                Console.WriteLine("500보다 큽니다.");
            }
            */
            int point = 77;
            string result;
            if (point >= 0 && point <= 100)
            {
                if (point > 50)
                {
                    result = "Pass";
                }
                else
                {
                    result = "Fail";
                }
                Console.WriteLine("결과 : " + result);
            }
            else
            {
                Console.WriteLine("에러:범위를 벗어났습니다.");
            }

            bool a;
            a = (point > 50) ? true : false ;
            Console.WriteLine("{0}",a);

        }
    }
}
