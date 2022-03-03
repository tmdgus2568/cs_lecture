using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_constructor_static
{
    class Test
    {
        // public static int staticint = 0; // 이렇게 초기화 보다는 

        public static int staticint;

        static Test() // static 생성자
        // => static member field가 메모리에 올라가고 나서 바로 호출됨
        {
            // 생성자를 통해 초기화를 하는 것이 좋다 
            staticint = 0;
            // 제어 로직이 가능 
        }

        public static void print()
        {
            Console.WriteLine("staticint value: {0}", staticint);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.print();
        }
    }
}
