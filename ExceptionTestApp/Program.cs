using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 5, value = 0;

            try //Error가 나면 try, Catch, Finally / 안나면 try, Finally 
            {
                value = x / y;
                Console.WriteLine($"{x} / {y} = {value}");
                throw new Exception("사용자 에러");
                //Console.write("{0}/{1} = {2}", x,y,value);
            }
            catch (DivideByZeroException ex)
            {
               
                Console.WriteLine("2. y의 값을 0보다 크게 입력하세요");
            }
            catch (Exception ex) // 마지막에 에러를 잡는 코드
            {
                Console.WriteLine("3. " + ex.Message);
            }
            finally //무조건 실행되는 값
            {
                Console.WriteLine("4. 프로그램이 종료했습니다.");
            }
        }
    }
}
