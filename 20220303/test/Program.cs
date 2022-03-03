using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        // 가위 < 바위 < 보 < 가위 ....
        // 지면 -1, 비기면 0, 이기면 1
        static int rcp(string robot, string person)
        {

            // 이기는 경우
            if (robot == "가위" && person == "바위"
                            || robot == "바위" && person == "보"
                            || robot == "보" && person == "가위") return 1;

            // 지는 경우
            if (robot == "바위" && person == "가위"
                            || robot == "보" && person == "바위"
                            || robot == "가위" && person == "보") return -1;

            // 비기는 경우 
            return 0;
        }

        static void Main(string[] args)
        {
            Boolean auto = true;
            while (auto)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("1. 시작 | 2. 종료");
                Console.WriteLine("===========================");
                Console.Write("입력 : ");
                string insert = Console.ReadLine();

                switch (insert)
                {
                    case "1":
                        Random rnd = new Random();
                        string robot = "";
                        switch (rnd.Next(1, 3))
                        {
                            case 1:
                                robot = "가위";
                                break;
                            case 2:
                                robot = "바위";
                                break;
                            case 3:
                                robot = "보";
                                break;
                        }

                        while (true)
                        {
                            Console.Write("가위 / 바위 / 보 중에 선택해주세요 : ");
                            string person = Console.ReadLine();

                            if (person.Equals("가위") || person.Equals("바위") || person.Equals("보"))
                            {
                                Console.WriteLine($"로봇: {robot},\t당신: {person}");
                                int result = rcp(robot, person);
                                if (result == 0) Console.WriteLine("비겼습니다~");
                                else if (result == -1) Console.WriteLine("졌습니다..");
                                else Console.WriteLine("이겼습니다!!!!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("올바르게 선택하세요");
                            }
                        }

                        break;


                    case "2":
                        auto = false;
                        Console.WriteLine("프로그램을 종료합니다. 안녕히가세요(__)");
                        break;

                    default:
                        Console.WriteLine("올바른 메뉴를 선택하세요");
                        break;
                }
            }
        }
    }
}
