using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputdata = 0;
            do
            {
                Console.Write("숫자를 입력해 주세요(0~9): ");
                inputdata = int.Parse(Console.ReadLine());

            } while (inputdata >= 10); // 조건이 true면 do 문을 계속 실행 
            Console.WriteLine("당신이 입력한 숫자는:{0}", inputdata);

            int a = 0, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }

            // java의 ==은 주소값 비교, 문자열은 값이 중요
            // C# == 사용 가능
            string opr = "+";
            if (opr == "+")
            {
                Console.WriteLine("같은 문자열");
            }
        }
        
    }
}
