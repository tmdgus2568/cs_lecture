using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_static_scope
{
    public class Test // 원칙 : class 내부에서 public, private 같이 식구.....
    {
        private static int i; // private 접근자 > 클래스 이름 접근 불가 > Test.i (x)
        public static int j; // public 접근자 > 클래스 이름 접근 가능 > Test.j (o)
        // 클래스가 일반자원과 static자원 다 가지고 있는 경우
        // 일반함수에서 static member 가지고 놀 수 있다 (메모리 생성 시점이 항상 static 우선)
        // static 함수에서 일반 member 가지고 놀 수 있다. (static 은 일반자원보다 항상 우선)
        public static void method()
        {
            i = 100;
            j = 200;
            Console.WriteLine("method => i: {0}, j: {1}", i, j);
        }
        public void gMethod()
        {
            // 일반 함수가 static 자원을 가지고 노는 것은 당연하다.
            // 생성 시점이 static보다 늦기 때문에 
            i = 111;
            j = 222;
            Console.WriteLine("gMethod => i: {0}, j: {1}", i, j);
        }
    }

    class Test2
    {
        public static int sk;
        public int gk;

        public void method()
        {
            //sk 변수 접근 (o)
            //gk 변수 접근 (o)
            sk = 100;
            gk = 200;
        } 

        public static void sMethod()
        {
            //sk 변수 접근 (o) : 같은 식구는 static 서로 접근 가능 
            //gk 변수 접근 (x) : 일반 자원이 생성 전이므로 접근 불가능 
            sk++;
            // gk++; => 접근 불가가 아니고 생성자체가 안되어있다
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // static 함수
            Test.method();
            
            // gMethod()는 안돼요... 메모리에 올려야죠 -> new
            Test t = new Test();
            t.gMethod();
        }
    }
}
