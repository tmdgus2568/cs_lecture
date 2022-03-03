using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_const_readonly
{
    class Test
    {
        // const로 상수 생성시
        // 1. 객체간 공유자원이 된다. => 자동으로 static이 붙어버린다.
        // 2. 의무적(강제) 초기화가 필요하다
        public const int MAXVALUE = 100000;

        // readonly로 상수 생성시
        // 1. 반드시 초기화 할 필요가 없다.
        // 2. 생성자에서 딱 한번 값을 할당할 수 있다. => 변경 불가 
        public readonly int readdata; 

        public Test(int data)
        {
            readdata = data; // new 통한 생성 시, 객체마다 다른 상수값을 가지게 할 수 있다.
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // const
            Console.WriteLine(Test.MAXVALUE);
            Test t = new Test(10);
            Console.WriteLine("t.readdata : {0}",t.readdata);

            Test t2 = new Test(20);
            Console.WriteLine("t2.readdata : {0}", t2.readdata);
            // t2.readdata = 100; => 이미 값을 가지고 있기 때문에 변경 불가
            // read만 가능 
        }
    }
}
