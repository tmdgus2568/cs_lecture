using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallByVal_CallByRef
{
    class Test
    {
        public void print()
        {
            Console.WriteLine(printdata());
        }
        private int printdata()
        {
            // 1. private 함수 : 클래스 내부에서 사용 가능
            // 2. 다른 함수를 도와줄 목적 
            // 3. 공통 함수(출력)
            return 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
