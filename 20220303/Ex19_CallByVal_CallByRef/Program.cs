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

    class Car
    {
        public int speed;
        public void run(int data)
        {
            speed += data;
            data = 100;
            
        }
    }

    // ref
    class Car2
    {
        public int speed;
        public void run(ref int data)
        {
            speed += data;
            data += 50;

        }
    }

    // out
    class Car3
    {
        public int speed;
        public void run(out int data)
        {
            data = 100;
            speed += data;
            data += 50;

        }
    }

    // out과  ref는 초기화를 할지말지의 차이일 뿐


    class Program
    {
        static void Main(string[] args)
        {
            // 실제로 자주 사용하지는 않지만 
            // 알아두면 좋다 (주소값개념이지 포인터의 개념은 아니다.)

            Car car = new Car();
            int data2 = 20;
            car.run(data2); // data2 변수가 가지는 값을 전달
            Console.WriteLine(car.speed);
            Console.WriteLine("data2: {0}", data2);

            Car2 car2 = new Car2();
            int data3 = 20;
            car2.run(ref data3); // data2 변수가 가지는 값을 전달
                                 // stack 메모리에있는 주소를 전달한다

            Car3 car3 = new Car3();
            int data4 = 20;
            car3.run(out data4);

            Console.WriteLine(car2.speed);
            Console.WriteLine("data3: {0}", data3);

        }
    }
}
